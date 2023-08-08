using EducationalInstitution.Api.Data;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Repository;
using EducationalInstitution.Api.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using EducationalInstitution.Api.Services.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using EducationalInstitution.Api.Models.Identity;
using EducationalInstitution.Api.Services.Common.Contracts;
using EducationalInstitution.Api.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<DataContext>(
  options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, Role>(options =>
   {
       options.User.RequireUniqueEmail = true;
       options.Password.RequireDigit = true;
       options.Password.RequireLowercase = true;
       options.Password.RequireUppercase = true;
       options.Password.RequireNonAlphanumeric = false;
       options.Password.RequiredLength = 8;
       options.SignIn.RequireConfirmedPhoneNumber = true;
   })
   .AddEntityFrameworkStores<DataContext>()
   .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
});
builder.Services.AddAuthorization();
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();



builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
builder.Services.AddScoped<IAdministratorService, AdministratorService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<IRegistrationInvoiceService, RegistrationInvoiceService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IScheduleService, ScheduleService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IInstitutionInformationService, InstitutionInformationService>();
builder.Services.AddScoped<IMiscellaneousExpenseService, MiscellaneousExpenseService>();
builder.Services.AddScoped<IPaymentOfSalaryService, PaymentOfSalaryService>();
builder.Services.AddScoped<ISiteAccessControlService, SiteAccessControlService>();
builder.Services.AddScoped<IInterestRateService, InterestRateService>();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();

var app = builder.Build();

// Add CORS configuration
var allowedOrigins = builder.Configuration.GetValue<string>("AllowedOrigins")?.Split(",") ?? Array.Empty<string>();

builder.Services.AddCors(options =>
 {
     options.AddPolicy("GlobomanticsInternal", builder =>
      builder.AllowAnyOrigin()
     .AllowAnyMethod()
      .AllowAnyHeader()
     .AllowCredentials());

     options.AddPolicy("PublicApi", builder =>
      builder.AllowAnyOrigin()
     .WithMethods("Get")
     .WithHeaders("Content-Type"));

 });


//app.UseCors(options =>
//{
//    options.WithOrigins("https://example.com")
//           .AllowAnyMethod()
//           .AllowAnyHeader();
//});

var dbContext = app.Services.GetRequiredService<IDbContextFactory<DataContext>>();
DataInitializer.Initialize(dbContext.CreateDbContext());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("GlobomanticsInternal");

app.Run();
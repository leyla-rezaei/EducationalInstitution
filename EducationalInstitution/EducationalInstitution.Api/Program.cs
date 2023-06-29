using EducationalInstitution.Api.Data;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Repository;
using EducationalInstitution.Api.Services.Contracts;
using EducationalInstitution.Api.Services.Implementation;
using EducationalInstitution.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<DataContext>(
  options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));

builder.Services.AddScoped<IAdministratorService, AdministratorService>();
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<IRegistrationInvoiceService, RegistrationInvoiceService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITotalBillService, TotalBillService>();
builder.Services.AddScoped<IScheduleService, ScheduleService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IInstitutionInformationService, InstitutionInformationService>();
builder.Services.AddScoped<IMiscellaneousExpenseService, MiscellaneousExpenseService>();
builder.Services.AddScoped<IPaymentOfSalaryService, PaymentOfSalaryService>();
builder.Services.AddScoped<ISiteAccessControlService, SiteAccessControlService>();


var app = builder.Build();

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

app.Run();
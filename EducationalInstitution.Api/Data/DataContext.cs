using EducationalInstitution.Api.Models.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;
using System.Reflection.Metadata;

namespace EducationalInstitution.Api.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser, Role, Guid>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes()
                .Where(q => q.GetCustomAttributes()
                .Any(a => a.GetType() == typeof(CustomAttribute)));

            foreach (var type in types)
            {
                var attributes = type.GetCustomAttributes<EntityTypeConfigurationAttribute>(inherit: false);

                if (attributes.Any())
                {
                    modelBuilder.Entity<EntityEntry>().ToTable("EntityEntry");
                }
            }

            foreach (var type in types)
            {
                var configurationType = type.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

                if (configurationType != null)
                {
                    var entityType = configurationType.GetGenericArguments().First();
                    var configuration = Activator.CreateInstance(type);
                    modelBuilder.ApplyConfigurationsFromAssembly(assembly);
                }
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreationDate = DateTimeOffset.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModificationDate = DateTimeOffset.UtcNow;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreationDate = DateTimeOffset.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModificationDate = DateTimeOffset.UtcNow;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<InstitutionInformation> InstitutionInformations { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<SiteAccessControl> SiteAccessControls { get; set; }
    }
}
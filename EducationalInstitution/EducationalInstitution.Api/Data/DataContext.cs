using EducationalInstitution.Api.Models.Common;
using EducationalInstitution.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducationalInstitution.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
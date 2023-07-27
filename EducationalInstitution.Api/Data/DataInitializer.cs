using Microsoft.EntityFrameworkCore;

namespace EducationalInstitution.Api.Data
{
    public class DataInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.Migrate();
        }
    }
}
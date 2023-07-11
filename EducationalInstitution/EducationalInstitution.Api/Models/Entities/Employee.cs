using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Employee : User
    {
        public Position Position { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public DateTimeOffset HiringDate { get; set; }
    }
}
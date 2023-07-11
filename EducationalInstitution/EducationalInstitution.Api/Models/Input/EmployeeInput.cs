using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public class EmployeeInput : UserInput
    {
        public Position Position { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public DateTimeOffset HiringDate { get; set; }
    }
}
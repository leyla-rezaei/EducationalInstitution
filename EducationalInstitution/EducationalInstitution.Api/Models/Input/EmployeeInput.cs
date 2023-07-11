using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Validations;

namespace EducationalInstitution.Api.Models.Input
{
    public class EmployeeInput : UserInput
    {
        public Position Position { get; set; }
        [BirthDate]
        public DateTimeOffset BirthDate { get; set; }
        [HiringDate]
        public DateTimeOffset HiringDate { get; set; }
    }
}
using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Validations;

namespace EducationalInstitution.Api.Models.Input
{
    public class EmployeeInput : UserInput
    {
        public Position Position { get; set; }
        [BirthDate("yyyy-MM-dd")]
        public DateTimeOffset BirthDate { get; set; }
        [HiringDate("yyyy-MM-dd")]
        public DateTimeOffset HiringDate { get; set; }
    }
}
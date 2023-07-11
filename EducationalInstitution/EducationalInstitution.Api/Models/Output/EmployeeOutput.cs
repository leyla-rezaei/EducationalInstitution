using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Output;

namespace EducationalInstitution.Api.Models.Input
{
    public class EmployeeOutput : UserOutput
    {
        public Position Position { get; set; }
        public DateTimeOffset HiringDate { get; set; }
    }
}
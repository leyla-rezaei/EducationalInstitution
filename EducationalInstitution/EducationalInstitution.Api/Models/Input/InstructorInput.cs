using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public class InstructorInput : UserInput
    {
        public string FieldOfStudy { get; set; }
        public string Resume { get; set; }
        public string Contract { get; set; }
        public string Specialty { get; set; }
    }
}
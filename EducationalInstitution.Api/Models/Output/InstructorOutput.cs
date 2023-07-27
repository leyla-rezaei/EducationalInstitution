using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class InstructorOutput : UserOutput
    {
        public string FieldOfStudy { get; set; }
        public string Resume { get; set; }
        public string Contract { get; set; }
        public string Specialty { get; set; }
    }
}
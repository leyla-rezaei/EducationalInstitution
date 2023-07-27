using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class StudentOutput : UserOutput
    {
        public int Id { get; set; }
        public string FatherName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string NatioanlCode { get; set; }
    }
}
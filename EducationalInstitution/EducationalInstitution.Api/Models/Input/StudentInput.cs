using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Validations;

namespace EducationalInstitution.Api.Models.Input
{
    public class StudentInput : UserInput
    {
        public string FatherName { get; set; }
        [BirthDate]
        public DateTimeOffset BirthDate { get; set; }
        [NationalCode]
        public string NatioanlCode { get; set; }
    }
}
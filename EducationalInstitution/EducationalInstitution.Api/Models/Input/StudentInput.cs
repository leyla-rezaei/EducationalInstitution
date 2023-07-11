using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public class StudentInput : UserInput
    {
        public string FatherName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string NatioanlCode { get; set; }
        public Gender Gender { get; set; }
    }
}
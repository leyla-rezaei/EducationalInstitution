using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Student : User
    {
        public string FatherName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string NatioanlCode { get; set; }
     
        //Relations
        public Class Class { get; set; }
        public int ClassId { get; set; }


        //Collections
        public ICollection<CourseStudent> CourseStudents { get; set; }
        public ICollection<RegistrationInvoice> RegistrationInvoices { get; set; }
    }
}
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class RegistrationInvoiceOutput
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public decimal TotalTuition { get; set; }
        public decimal TotalNumberCourses { get; set; }
        public string TrackingCode { get; set; }
        public int DepositID { get; set; }
        public string Description { get; set; }
        

        //Relations
        public CourseStudent CourseStudent { get; set; }
        public int CourseStudentId { get; set; }
    }
}
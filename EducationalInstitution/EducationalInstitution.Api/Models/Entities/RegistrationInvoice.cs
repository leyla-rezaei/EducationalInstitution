using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class RegistrationInvoice : BaseEntity
    {
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
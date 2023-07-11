using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class RegistrationInvoiceOutput
    {
        public int Id { get; set; }
        public decimal TotalTuition { get; set; }
        public int TotalNumberCourses { get; set; }
        public string TrackingCode { get; set; }
        public int DepositID { get; set; }
        public string Description { get; set; }
    }
}
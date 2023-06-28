namespace EducationalInstitution.Api.Models.Input
{
    public class RegistrationInvoiceInput
    {
        public decimal TotalTuition { get; set; }
        public decimal TotalNumberCourses { get; set; }
        public string TrackingCode { get; set; }
        public int DepositID { get; set; }
        public string Description { get; set; }
    }
}
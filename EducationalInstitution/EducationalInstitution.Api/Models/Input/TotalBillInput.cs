using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Input
{
    public class TotalBillInput 
    {

        public string Description { get; set; }

        //Relations
        public PaymentOfSalary PaymentOfSalary { get; set; }
        public int PaymentOfSalaryId { get; set; }

        public RegistrationInvoice RegistrationInvoice { get; set; }
        public int RegistrationInvoiceId { get; set; }
    }
}
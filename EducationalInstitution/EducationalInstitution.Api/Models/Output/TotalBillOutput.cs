using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;

namespace EducationalInstitution.Api.Models.Output
{
    public class TotalBillOutput 
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }


        //Relations
        public PaymentOfSalary PaymentOfSalary { get; set; }
        public int PaymentOfSalaryId { get; set; }

        public RegistrationInvoice RegistrationInvoice { get; set; }
        public int RegistrationInvoiceId { get; set; }
    }
}
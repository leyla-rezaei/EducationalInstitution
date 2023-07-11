using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class TotalBill : BaseEntity
    {
        public string Description { get; set; }

        //Relations
        public PaymentOfSalary PaymentOfSalary { get; set; }
        public int PaymentOfSalaryId { get; set; }

        public RegistrationInvoice RegistrationInvoice { get; set; }
        public int RegistrationInvoiceId { get; set; }
    }
}
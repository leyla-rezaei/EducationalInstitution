using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class DepositAmount : BaseEntity
    {
        public decimal Amount { get; set; }


        //Relations
        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }

        //Collections
        public ICollection<RegistrationInvoice>  RegistrationInvoices{ get; set; }
        public ICollection<InterestRate>  InterestRates{ get; set; }
    }
}
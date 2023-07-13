using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class DepositAmount : BaseEntity
    {
        public decimal Amount { get; set; }
        public void CalculateAmount()
        { 
            decimal InterestRateTotal = 0;
            decimal RegistrationInvoiceTotal = 0;

            foreach (var interestRate in InterestRates)
            {
                InterestRateTotal += interestRate.Amount;
            }

            foreach (var registrationInvoice in RegistrationInvoices)
            {
                RegistrationInvoiceTotal += registrationInvoice.TotalTuition;
            }

            Amount = RegistrationInvoiceTotal + InterestRateTotal;
        }


        //Relations
        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }

        //Collections
        public ICollection<RegistrationInvoice>  RegistrationInvoices{ get; set; }
        public ICollection<InterestRate>  InterestRates{ get; set; }
    }
}
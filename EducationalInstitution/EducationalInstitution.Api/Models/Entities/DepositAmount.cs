using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class DepositAmount : BaseEntity
    {
        public decimal Amount { get; set; }
        public void CalculateAmount()
        { 
            decimal totalInterestRate = 0;
            decimal totalRegistrationInvoice = 0;

            foreach (var interestRate in InterestRates)
            {
                totalInterestRate += interestRate.Amount;
            }

            foreach (var registrationInvoice in RegistrationInvoices)
            {
                totalRegistrationInvoice += registrationInvoice.TotalTuition;
            }

            Amount = totalRegistrationInvoice + totalInterestRate;
        }
          

        //Relations
        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }

        //Collections
        public ICollection<RegistrationInvoice>  RegistrationInvoices{ get; set; }
        public ICollection<InterestRate>  InterestRates{ get; set; }
    }
}
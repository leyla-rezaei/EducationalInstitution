using EducationalInstitution.Api.Models.Common;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models
{
    public class Transaction : BaseEntity
    {
        public DateTimeOffset Date { get; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public void CalculateBalance()
        {
            decimal depositTotal = 0;
            decimal withdrawalTotal = 0;

            foreach (var deposit in DepositAmounts)
            {
                depositTotal += deposit.Amount;
            }

            foreach (var withdrawal in WithdrawalAmounts)
            {
                withdrawalTotal += withdrawal.Amount;
            }

            Balance = depositTotal - withdrawalTotal;
        }

        //Relations
        public BankAccount BankAccount  { get; set; }
        public int BankAccountId { get; set; } 

        //Collections
        public ICollection<WithdrawalAmount> WithdrawalAmounts { get; set; }
        public ICollection<DepositAmount> DepositAmounts { get; set; }
    }
}
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
            decimal totalDeposit = 0;
            decimal totalWithdrawal = 0;

            foreach (var deposit in DepositAmounts)
            {
                totalDeposit += deposit.Amount;
            }

            foreach (var withdrawal in WithdrawalAmounts)
            {
               totalWithdrawal += withdrawal.Amount;
            }

            Balance = totalDeposit - totalWithdrawal;
        }

        //Relations
        public BankAccount BankAccount  { get; set; }
        public int BankAccountId { get; set; } 

        //Collections
        public ICollection<WithdrawalAmount> WithdrawalAmounts { get; set; }
        public ICollection<DepositAmount> DepositAmounts { get; set; }
    }
}
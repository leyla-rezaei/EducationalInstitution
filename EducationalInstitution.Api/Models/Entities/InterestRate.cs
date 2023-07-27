using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class InterestRate : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTimeOffset Date  { get; set; }


        //Relations
        public BankAccount BankAccount  { get; set; }
        public int BankAccountId { get; set; }

        public DepositAmount DepositAmount { get; set; }
        public int DepositAmountId { get; set; }
    }
} 
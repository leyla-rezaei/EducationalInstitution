using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class MiscellaneousExpense : BaseEntity
    {
        public string FeeFor { get; set; } 
        public decimal Amount { get; set; } 
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }

        //Relations
        public WithdrawalAmount WithdrawalAmount { get; set; }
        public int WithdrawalAmountId { get; set; }
    }
}
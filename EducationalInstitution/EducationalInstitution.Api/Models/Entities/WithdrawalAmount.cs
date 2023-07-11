using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class WithdrawalAmount : BaseEntity
    {
        public decimal Amount { get; set; }


        //Relations

        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }


        //Collections
        public ICollection<MiscellaneousExpense> MiscellaneousExpenses { get; set; }
        public ICollection<PaymentOfSalary> PaymentOfSalaries { get; set; }
    }
}
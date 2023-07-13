using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class WithdrawalAmount : BaseEntity
    {
        public decimal Amount { get; set; } 
        public void CalculateAmount()
        {  
            decimal MiscellaneousExpenseTotal = 0;
            decimal PaymentOfSalarieTotal = 0;

            foreach (var miscellaneousExpense in MiscellaneousExpenses)
            {
                MiscellaneousExpenseTotal += miscellaneousExpense.Amount;
            }

            foreach (var paymentOfSalary in PaymentOfSalaries)
            {
                PaymentOfSalarieTotal += paymentOfSalary.SalaryAmount;
            }

            Amount = PaymentOfSalarieTotal + MiscellaneousExpenseTotal;
        }

         
        //Relations

        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }


        //Collections
        public ICollection<MiscellaneousExpense> MiscellaneousExpenses { get; set; }
        public ICollection<PaymentOfSalary> PaymentOfSalaries { get; set; }
    }
}
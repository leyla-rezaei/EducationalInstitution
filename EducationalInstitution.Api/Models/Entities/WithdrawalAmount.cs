﻿using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class WithdrawalAmount : BaseEntity
    {
        public decimal Amount { get; set; } 
        public void CalculateAmount()
        {  
            decimal totalMiscellaneousExpense = 0;
            decimal totalPaymentOfSalarie = 0;

            foreach (var miscellaneousExpense in MiscellaneousExpenses)
            {
                totalMiscellaneousExpense += miscellaneousExpense.Amount;
            }

            foreach (var paymentOfSalary in PaymentOfSalaries)
            {
                totalPaymentOfSalarie += paymentOfSalary.Amount;
            }

            Amount = totalPaymentOfSalarie + totalMiscellaneousExpense;
        }

         
        //Relations

        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }


        //Collections
        public ICollection<MiscellaneousExpense> MiscellaneousExpenses { get; set; }
        public ICollection<PaymentOfSalary> PaymentOfSalaries { get; set; }
    }
}
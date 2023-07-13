﻿using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class WithdrawalAmountService : BaseService<WithdrawalAmount, WithdrawalAmountInput>, IWithdrawalAmountService
    {
        public WithdrawalAmountService(IBaseRepository<WithdrawalAmount> repository) : base(repository)
        { }
        public override SingleResponse<WithdrawalAmount> Create(WithdrawalAmountInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            // Check if a withdrawal amount with the same transaction id already exists

            //using var scope = new TransactionScope();

            //var result = Get()
            //    .Where(x => x.TransactionId == input.Amount)
            //    .Any();

            //if (result) return ResponseStatus.AlreadyExist;

            //scope.Complete();
            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<WithdrawalAmount> Update(int id, WithdrawalAmountInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            //var resultExist = Get()
            //.Where(x => x.TransactionId == input.Amount && x.Id != id)
            //.Any();

            //if (resultExist) return ResponseStatus.AlreadyExist;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExistMiscellaneousExpense = Get<MiscellaneousExpense>()
             .Where(x => x.WithdrawalAmountId == id)
              .Any();

            var resultExistPaymentOfSalary = Get<PaymentOfSalary>()
           .Where(x => x.WithdrawalAmountId == id)
            .Any();

            if (resultExistMiscellaneousExpense || resultExistPaymentOfSalary)
                return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
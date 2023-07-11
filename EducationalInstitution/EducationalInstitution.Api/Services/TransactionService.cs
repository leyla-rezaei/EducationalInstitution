using EducationalInstitution.Api.Models;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class TransactionService : BaseService<Transaction, TransactionInput>, ITransactionService
    {
        public TransactionService(IBaseRepository<Transaction> repository) : base(repository)
        { }
        public override SingleResponse<Transaction> Create(TransactionInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Transaction> Update(int id, TransactionInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExistWithdrawalAmount = Get<WithdrawalAmount>()
             .Where(x => x.TransactionId == id)
              .Any();
            var resultExistDepositAmount = Get<DepositAmount>()
               .Where(x => x.TransactionId == id)
                .Any();
            if (resultExistDepositAmount || resultExistWithdrawalAmount)
                return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
using EducationalInstitution.Api.Models;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Common;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.EntitiesService
{
    public class BankAccountService : BaseService<BankAccount, BankAccountInput>, IBankAccountService
    {
        public BankAccountService(IBaseRepository<BankAccount> repository) : base(repository)
        { }

        public override SingleResponse<BankAccount> Create(BankAccountInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<BankAccount> Update(int id, BankAccountInput input)
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

            var resultExist = Get<Transaction>()
             .Where(x => x.BankAccountId == id)
              .Any();

            if (resultExist)
                return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
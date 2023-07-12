using EducationalInstitution.Api.Models;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Services
{
    public class BankAccountService : BaseService<BankAccount, BankAccountInput>, IBankAccountService
    {
        public BankAccountService(IBaseRepository<BankAccount> repository) : base(repository)
        { }

        public override SingleResponse<BankAccount> Create(BankAccountInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<BankAccount> Update(int id, BankAccountInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

   
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
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Common;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.EntitiesService
{
    public class InterestRateService : BaseService<InterestRate, InterestRateInput>, IInterestRateService
    {
        public InterestRateService(IBaseRepository<InterestRate> repository) : base(repository)
        { }

        public override SingleResponse<InterestRate> Create(InterestRateInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            //using var scope = new TransactionScope();

            //var result = Get()
            //    .Where(x => x.BankAccountId == input.Amount
            //    && x.DepositAmountId == input.Amount
            //    && x.Date == input.Date
            //    && x.Amount == input.Amount)
            //    .Any();

            //if (result) return ResponseStatus.AlreadyExist;

            //  scope.Complete();
            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<InterestRate> Update(int id, InterestRateInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            //var resultExist = Get()
            //.Where(x => x.BankAccountId == input.Amount
            //&& x.DepositAmountId == input.Amount
            //&& x.Date == input.Date && x.Amount == input.Amount
            //&& x.Id != id)
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

            return Delete(id);
        }
    }
}
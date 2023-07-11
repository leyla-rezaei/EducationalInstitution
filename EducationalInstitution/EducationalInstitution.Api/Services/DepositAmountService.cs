using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class DepositAmountService : BaseService<DepositAmount, DepositAmountInput>, IDepositAmountService
    {
        public DepositAmountService(IBaseRepository<DepositAmount> repository) : base(repository)
        { }
        public override SingleResponse<DepositAmount> Create(DepositAmountInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<DepositAmount> Update(int id, DepositAmountInput input)
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
            var resultExistRegistrationInvoice = Get<RegistrationInvoice>()
                 .Where(x => x.DepositAmountId == id)
                  .Any();
            var resultExistInterestRate = Get<InterestRate>()
           .Where(x => x.DepositAmountId == id)
            .Any();
            if (resultExistRegistrationInvoice || resultExistInterestRate)
                return ResponseStatus.UnknownError;
            return Delete(id);
        }
    }
}
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class InterestRateService : BaseService<InterestRate, InterestRateInput>, IInterestRateService
    {
        public InterestRateService(IBaseRepository<InterestRate> repository) : base(repository)
        { }
        public override SingleResponse<InterestRate> Create(InterestRateInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<InterestRate> Update(int id, InterestRateInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

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
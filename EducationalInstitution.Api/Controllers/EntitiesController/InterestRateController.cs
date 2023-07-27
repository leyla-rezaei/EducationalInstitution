using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers.EntitiesController
{
    public class InterestRateController : BaseController<IInterestRateService, InterestRate, InterestRateInput>
    {
        public InterestRateController(IInterestRateService service) : base(service)
        { }
    }
}
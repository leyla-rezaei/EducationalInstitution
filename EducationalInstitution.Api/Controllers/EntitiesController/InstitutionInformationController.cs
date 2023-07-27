using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers.EntitiesController
{
    public class InstitutionInformationController : BaseController<IInstitutionInformationService, InstitutionInformation, InstitutionInformationInput>
    {
        public InstitutionInformationController(IInstitutionInformationService service) : base(service)
        { }
    }
}
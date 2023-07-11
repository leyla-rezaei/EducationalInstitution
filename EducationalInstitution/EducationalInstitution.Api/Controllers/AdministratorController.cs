using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class AdministratorController : BaseController<IAdministratorService, Administrator, AdministratorInput>
    {
        public AdministratorController(IAdministratorService service) : base(service)
        { }
    }
}    
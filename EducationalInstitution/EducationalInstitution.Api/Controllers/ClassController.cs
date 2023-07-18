using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class ClassController : BaseController<IClassService, Class, ClassInput>
    {
        public ClassController(IClassService service) : base(service)
        { }
    }
}
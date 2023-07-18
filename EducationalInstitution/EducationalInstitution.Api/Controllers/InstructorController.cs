using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class InstructorController : BaseController<IInstructorService, Instructor, InstructorInput>
    {
        public InstructorController(IInstructorService service) : base(service)
        { }
    }
}
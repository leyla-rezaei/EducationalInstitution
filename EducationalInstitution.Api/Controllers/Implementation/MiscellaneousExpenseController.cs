using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers.Implementation
{
    public class MiscellaneousExpenseController : BaseController<IMiscellaneousExpenseService, MiscellaneousExpense, MiscellaneousExpenseInput>
    {
        public MiscellaneousExpenseController(IMiscellaneousExpenseService service) : base(service)
        { }
    }
}
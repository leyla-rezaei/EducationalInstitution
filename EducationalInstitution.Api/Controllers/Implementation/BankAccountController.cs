using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers.Implementation
{
    public class BankAccountController : BaseController<IBankAccountService, BankAccount, BankAccountInput>
    {
        public BankAccountController(IBankAccountService service) : base(service)
        { }
    }
}
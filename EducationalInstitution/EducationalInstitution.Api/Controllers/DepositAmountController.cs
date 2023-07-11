using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;


namespace EducationalInstitution.Api.Controllers
{
    public class DepositAmountController : BaseController<IDepositAmountService, DepositAmount, DepositAmountInput>
    {
        public DepositAmountController(IDepositAmountService service) : base(service)
        { }
    }
}
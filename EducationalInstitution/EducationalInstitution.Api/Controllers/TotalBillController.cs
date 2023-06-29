using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class TotalBillController : BaseController<ITotalBillService, TotalBill, TotalBillInput>
    {
        public TotalBillController(ITotalBillService service) : base(service)
        { }
    }
}
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class RegistrationInvoiceController : BaseController<IRegistrationInvoiceService, RegistrationInvoice, RegistrationInvoiceInput>
    {
        public RegistrationInvoiceController(IRegistrationInvoiceService service) : base(service)
        { }
    }
}
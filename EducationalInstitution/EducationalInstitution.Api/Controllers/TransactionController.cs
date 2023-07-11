using EducationalInstitution.Api.Models;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class TransactionController : BaseController<ITransactionService, Transaction, TransactionInput>
    {
        public TransactionController(ITransactionService service) : base(service)
        { }
    }
}
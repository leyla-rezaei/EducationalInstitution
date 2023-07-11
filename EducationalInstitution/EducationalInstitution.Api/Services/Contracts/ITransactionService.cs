using EducationalInstitution.Api.Models;
using EducationalInstitution.Api.Models.Input;

namespace EducationalInstitution.Api.Services.Contracts
{
    public interface ITransactionService : IBaseService<Transaction, TransactionInput>
    { }
}
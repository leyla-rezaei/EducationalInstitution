using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Common.Contracts;

namespace EducationalInstitution.Api.Services.Contracts
{
    public interface IMiscellaneousExpenseService : IBaseService<MiscellaneousExpense, MiscellaneousExpenseInput>
    { }

}
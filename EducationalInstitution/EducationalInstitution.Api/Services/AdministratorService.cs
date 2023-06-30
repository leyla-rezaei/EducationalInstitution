using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class AdministratorService : BaseService<Administrator, AdministratorInput>, IAdministratorService
    {
        public AdministratorService(IBaseRepository<Administrator> repository) : base(repository)
        { }
        public override SingleResponse<Administrator> Create(AdministratorInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Administrator> Update(int id, AdministratorInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExist = Get<Message>()
             .Where(x => x.Id == id)
              .Any();

            if (resultExist)
                return ResponseStatus.UnknownError;


            return Delete(id);
        }
    }
}
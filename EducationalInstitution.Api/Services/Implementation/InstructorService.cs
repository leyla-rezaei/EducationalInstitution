using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Common;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class InstructorService : BaseService<Instructor, InstructorInput>, IInstructorService
    {
        public InstructorService(IBaseRepository<Instructor> repository) : base(repository)
        { }
        public override SingleResponse<Instructor> Create(InstructorInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Instructor> Update(int id, InstructorInput input)
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

            var resultExistClass = Get<Class>()
               .Where(x => x.InstructorId == id)
                .Any();
            var resultExistMessage = Get<Message>()
             .Where(x => x.UserId == id)
              .Any();

            if (resultExistClass || resultExistMessage) return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
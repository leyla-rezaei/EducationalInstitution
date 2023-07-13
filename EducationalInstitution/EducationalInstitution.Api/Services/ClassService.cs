using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class ClassService : BaseService<Class, ClassInput>, IClassService
    {
        public ClassService(IBaseRepository<Class> repository) : base(repository)
        { }
        public override SingleResponse<Class> Create(ClassInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Class> Update(int id, ClassInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExist = Get<Student>()
              .Where(x => x.ClassId == id)
               .Any();

            if (resultExist) return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
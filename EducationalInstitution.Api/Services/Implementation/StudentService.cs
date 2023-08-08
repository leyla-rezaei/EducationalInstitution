using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Common;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class StudentService : BaseService<Student, StudentInput>, IStudentService
    {
        public StudentService(IBaseRepository<Student> repository) : base(repository)
        { }
        public override SingleResponse<Student> Create(StudentInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Student> Update(int id, StudentInput input)
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

            var resultExistRegistrationInvoice = Get<RegistrationInvoice>()
               .Where(x => x.CourseStudentId == id)
                .Any();


            var resultExistCourseStudent = Get<CourseStudent>()
               .Where(x => x.StudentId == id)
                .Any();

            var resultExistMessage = Get<Message>()
              .Where(x => x.UserId == id)
               .Any();

            if (resultExistRegistrationInvoice || resultExistCourseStudent || resultExistMessage)
                return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
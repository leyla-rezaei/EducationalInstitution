using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services
{
    public class CourseService : BaseService<Course, CourseInput>, ICourseService
    {
        public CourseService(IBaseRepository<Course> repository) : base(repository)
        { }
        public override SingleResponse<Course> Create(CourseInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Course> Update(int id, CourseInput input)
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
              .Where(x => x.CourseId == id)
               .Any();

            var resultExistCourseStudent = Get<CourseStudent>()
              .Where(x => x.CourseId == id)
               .Any();

            var resultExistScheduleCourse = Get<ScheduleCourse>()
             .Where(x => x.CourseId == id)
              .Any();

            var resultExistRegistrationInvoice = Get<RegistrationInvoice>()
             .Where(x => x.CourseStudentId == id)
              .Any();

            if (resultExistClass || resultExistCourseStudent || resultExistScheduleCourse || resultExistRegistrationInvoice) return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
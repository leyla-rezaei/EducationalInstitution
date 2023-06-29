﻿using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class ClassService : BaseService<Class, ClassInput>, IClassService
    {
        public ClassService(IBaseRepository<Class> repository) : base(repository)
        { }
        public override SingleResponse<Class> Create(ClassInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<Class> Update(int id, ClassInput input)
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

            var resultExistStudent = Get<Student>()
              .Where(x => x.Id == id)
               .Any();

            var resultExistCourse = Get<Course>()
             .Where(x => x.Id == id)
              .Any();

            var resultExistInstructor = Get<Instructor>()
             .Where(x => x.Id == id)
              .Any();

            if (resultExistStudent || resultExistCourse || resultExistInstructor) return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
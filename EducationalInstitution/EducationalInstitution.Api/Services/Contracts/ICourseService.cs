﻿using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;

namespace EducationalInstitution.Api.Services.Contracts
{
    public interface ICourseService : IBaseService<Course, CourseInput>
    { }
}
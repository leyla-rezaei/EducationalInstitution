﻿using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class EmployeeController : BaseController<IEmployeeService, Employee, EmployeeInput>
    {
        public EmployeeController(IEmployeeService service) : base(service)
        { }
    }
}
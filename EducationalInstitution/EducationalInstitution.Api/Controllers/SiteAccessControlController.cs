﻿using EducationalInstitution.Api.Controllers.Common;
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Services.Contracts;

namespace EducationalInstitution.Api.Controllers
{
    public class SiteAccessControlController : BaseController<ISiteAccessControlService, SiteAccessControl, SiteAccessControlInput>
    {
        public SiteAccessControlController(ISiteAccessControlService service) : base(service)
        { }
    }
}
using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services.Implementation
{
    public class SiteAccessControlService : BaseService<SiteAccessControl, SiteAccessControlInput>,ISiteAccessControlService
    {
        public SiteAccessControlService(IBaseRepository<SiteAccessControl> repository) : base(repository)
        { } 
        public override SingleResponse<SiteAccessControl> Create(SiteAccessControlInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<SiteAccessControl> Update(int id, SiteAccessControlInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            return Delete(id);
        }
    }
}
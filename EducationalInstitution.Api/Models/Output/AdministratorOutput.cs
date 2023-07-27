using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class AdministratorOutput : UserOutput
    {
        public Position Position { get; set; }
    }
}
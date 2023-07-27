using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public class AdministratorInput : UserInput
    {
        public Position Position { get; set; }
    }
}
using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Administrator : User
    {
        public Position Position { get; set; }
    }
}
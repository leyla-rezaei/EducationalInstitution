using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class ClassOutput
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int Capacity { get; set; }
    }
}

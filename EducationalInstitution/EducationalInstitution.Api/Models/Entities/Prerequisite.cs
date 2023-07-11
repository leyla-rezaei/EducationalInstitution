using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Prerequisite : BaseEntity
    {
        //Collections
        public ICollection<Course> Courses { get; set; }
    }
}
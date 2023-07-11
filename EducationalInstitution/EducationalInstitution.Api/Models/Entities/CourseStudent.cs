using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class CourseStudent : BaseEntity
    {
        public Student Student { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
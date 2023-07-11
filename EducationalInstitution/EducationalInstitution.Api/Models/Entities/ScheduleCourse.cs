using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class ScheduleCourse : BaseEntity
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }

        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }
    }
}
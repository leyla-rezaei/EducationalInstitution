using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Schedule : BaseEntity
    {
        public AcademicSemester AcademicSemester { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public Weekday Weekday { get; set; }
        public DateTimeOffset ExamDate { get; set; }


        //Collections
        public ICollection<ScheduleCourse> ScheduleCourses { get; set; }
    }
}
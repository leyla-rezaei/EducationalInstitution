using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class ScheduleOutput
    {
        public int Id { get; set; }
        public AcademicSemester AcademicSemester { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public Weekday Weekday { get; set; }
        public DateTimeOffset ExamDate { get; set; }
    }
}
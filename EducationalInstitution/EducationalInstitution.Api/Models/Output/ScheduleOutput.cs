using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Output
{
    public class ScheduleOutput
    {
        public DateTimeOffset CreationDate { get; set; }
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
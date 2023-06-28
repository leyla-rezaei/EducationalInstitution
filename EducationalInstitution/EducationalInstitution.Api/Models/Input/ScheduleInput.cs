using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public class ScheduleInput
    {
        public AcademicSemester AcademicSemester { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public Weekday Weekday { get; set; }
        public DateTimeOffset ExamDate { get; set; }
    }
}
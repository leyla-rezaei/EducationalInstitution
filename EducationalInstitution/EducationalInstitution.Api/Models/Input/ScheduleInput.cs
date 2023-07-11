using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class ScheduleInput
    {
        public AcademicSemester AcademicSemester { get; set; }
        [StartDate]
        public DateTimeOffset StartDate { get; set; }
        [EndDate]
        public DateTimeOffset EndDate { get; set; }
        [Timestamp]
        public DateTimeOffset StartTime { get; set; }
        [Timestamp]
        public DateTimeOffset EndTime { get; set; }
        public Weekday Weekday { get; set; }
        [ExamDate]
        public DateTimeOffset ExamDate { get; set; }
    }
}
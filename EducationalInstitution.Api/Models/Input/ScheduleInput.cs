using EducationalInstitution.Api.Enum;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class ScheduleInput
    {
        public AcademicSemester AcademicSemester { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$",
            ErrorMessage = "Invalid date format. The correct format is yyyy-mm-dd.")]
        public DateTimeOffset StartDate { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$",
            ErrorMessage = "Invalid date format. The correct format is yyyy-mm-dd.")]
        public DateTimeOffset EndDate { get; set; }
        [Timestamp]
        public DateTimeOffset StartTime { get; set; }
        [Timestamp]
        public DateTimeOffset EndTime { get; set; }
        public Weekday Weekday { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$",
            ErrorMessage = "Invalid date format. The correct format is yyyy-mm-dd.")]
        public DateTimeOffset ExamDate { get; set; }
    }
}
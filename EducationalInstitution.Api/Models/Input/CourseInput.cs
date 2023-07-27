using EducationalInstitution.Api.Enum;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class CourseInput
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid amount value.")]
        public decimal Tuition { get; set; }
        [Range(0,100)]
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string? ExamEntranceCard { get; set; }
        public string? Certificate { get; set; }
        public string? Prerequisite { get; set; }
    }
}
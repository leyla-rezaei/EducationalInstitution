using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class CourseOutput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        public decimal Tuition { get; set; }
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string? ExamEntranceCard { get; set; }
        public string? Certificate { get; set; }
        public string? Prerequisite { get; set; }
    }
}
using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Output
{
    public class CourseOutput
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        public double Tuition { get; set; }
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string ExamEntranceCard { get; set; }
        public string Certificate { get; set; }
    }
}
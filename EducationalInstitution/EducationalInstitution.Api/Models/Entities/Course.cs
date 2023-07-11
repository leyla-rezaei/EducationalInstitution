using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        public double Tuition { get; set; }
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string? ExamEntranceCard { get; set; }
        public string? Certificate { get; set; }
        public string? Prerequisite { get; set; }
     

        //Collections
        public ICollection<ScheduleCourse> ScheduleCourses { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }
        public ICollection<RegistrationInvoice> RegistrationInvoices { get; set; }
    }
}
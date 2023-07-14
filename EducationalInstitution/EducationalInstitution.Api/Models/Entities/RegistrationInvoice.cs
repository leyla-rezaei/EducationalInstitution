using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class RegistrationInvoice : BaseEntity
    {
        public string TrackingCode { get; set; }
        public int DepositID { get; set; }
        public string Description { get; set; }
        public decimal TotalTuition { get; set; }
      
        public void CalculateTuition(List<Course> courses)
        {
            decimal totalTuition = 0;
            foreach (var course in courses)
            {
               totalTuition += course.Tuition;
            }
            TotalTuition = totalTuition;
        }
        public int TotalNumberCourses { get; set; }

        public void CalculateNumberCourses(List<Course> courses)
        {
            int totalNumber = 0;
            foreach (var course in courses)
            {
                totalNumber += 1;
            }
            TotalTuition = totalNumber;
        }


        //Relations
        public CourseStudent CourseStudent { get; set; }
        public int CourseStudentId { get; set; }
        public DepositAmount DepositAmount { get; set; }
        public int DepositAmountId { get; set; }
    } 
}
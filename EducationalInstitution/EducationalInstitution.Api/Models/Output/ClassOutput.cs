using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class ClassOutput
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public int Number { get; set; }

        public int Capacity { get; set; }
      
        //Relations
        public Instructor Professor { get; set; }
        public int ProfessorId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}

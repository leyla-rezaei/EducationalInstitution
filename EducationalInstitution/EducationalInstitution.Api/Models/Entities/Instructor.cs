using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Instructor : User
    {
        public string FieldOfStudy { get; set; }
        public string Resume { get; set; }
        public string Contract { get; set; }
        public string Specialty { get; set; }


        //Collections
        public ICollection<Class> Classes { get; set; }
        [NotMapped]
        public ICollection<Message> Messages { get; set; }
    }
}
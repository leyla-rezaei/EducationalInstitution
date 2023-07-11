using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class ClassInput
    {
        [Number]
        public int Number { get; set; }
        [Required]
        public int Capacity { get; set; } 
    }
}
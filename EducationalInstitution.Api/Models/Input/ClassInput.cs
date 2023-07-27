using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class ClassInput
    {
        [Required]
        public int Number { get; set; }
        [Range(0,255)]
        public byte Capacity { get; set; } 
    }
}
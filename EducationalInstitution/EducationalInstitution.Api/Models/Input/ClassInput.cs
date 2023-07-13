using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class ClassInput
    {
        public int Number { get; set; }
        public int Capacity { get; set; } 
    }
}
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class BankAccountInput
    {
        [Required]
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Owner { get; set; }
    }
}
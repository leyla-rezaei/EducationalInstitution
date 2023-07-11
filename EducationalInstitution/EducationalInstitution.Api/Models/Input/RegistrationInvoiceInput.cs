using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class RegistrationInvoiceInput
    {
        [Required]
        public decimal TotalTuition { get; set; }
        public string Description { get; set; }
    }
}
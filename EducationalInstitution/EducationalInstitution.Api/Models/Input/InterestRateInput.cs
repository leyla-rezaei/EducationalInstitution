using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class InterestRateInput
    {
        [Required]
        public decimal Amount { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
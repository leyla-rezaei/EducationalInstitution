using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class InterestRateInput
    {
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid amount value.")]
        public decimal Amount { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset Date { get; set; }
    }
}
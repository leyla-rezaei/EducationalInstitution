using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        [Required]
        public string FeeFor { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid amount value.")]
        public decimal Amount { get; set; }
        public int DepositID { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset DepositDate { get; set; }
    }
}
using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        [Required]
        public string FeeFor { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [DepositID]
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
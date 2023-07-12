using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        public string FeeFor { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public int DepositID { get; set; }
      
        public DateTimeOffset DepositDate { get; set; }
    }
}
using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        public string FeeFor { get; set; }
        [Required]
        public decimal SalaryAmount { get; set; }
        [Required]
        public int DepositID { get; set; }
        [DepositDate]
        public DateTimeOffset DepositDate { get; set; }
    }
}
using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        [Required]
        public string FeeFor { get; set; }
        [Amount]
        public decimal Amount { get; set; }
        public int DepositID { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset DepositDate { get; set; }
    }
}
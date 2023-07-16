
using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class PaymentOfSalaryInput
    {
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Invalid amount value.")]
        public decimal Amount { get; set; }
        public int DepositID { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset DepositDate { get; set; }
    }
}
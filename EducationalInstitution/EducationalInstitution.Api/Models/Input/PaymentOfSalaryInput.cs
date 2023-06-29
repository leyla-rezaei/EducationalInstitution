using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class PaymentOfSalaryInput
    {
        [Required]
        public decimal SalaryAmount { get; set; }
        [Required]
        public int DepositID { get; set; }
        [DepositDate]
        public DateTimeOffset DepositDate { get; set; }
    }
}

using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class PaymentOfSalaryInput
    {
        [Amount]
        public decimal Amount { get; set; }
        public int DepositID { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset DepositDate { get; set; }
    }
}
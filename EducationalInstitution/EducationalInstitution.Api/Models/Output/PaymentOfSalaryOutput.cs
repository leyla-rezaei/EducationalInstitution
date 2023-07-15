using EducationalInstitution.Api.Models.Entities;

namespace EducationalInstitution.Api.Models.Output
{
    public class PaymentOfSalaryOutput
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
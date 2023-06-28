namespace EducationalInstitution.Api.Models.Input
{
    public class PaymentOfSalaryInput
    {
        public decimal SalaryAmount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
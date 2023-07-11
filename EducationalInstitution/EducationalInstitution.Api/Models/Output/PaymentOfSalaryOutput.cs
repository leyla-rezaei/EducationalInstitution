namespace EducationalInstitution.Api.Models.Output
{
    public class PaymentOfSalaryOutput
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public decimal SalaryAmount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
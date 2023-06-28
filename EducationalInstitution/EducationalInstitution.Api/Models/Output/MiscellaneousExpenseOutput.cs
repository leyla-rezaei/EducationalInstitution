namespace EducationalInstitution.Api.Models.Output
{
    public class MiscellaneousExpenseOutput
    {
        public DateTimeOffset CreationDate { get; set; }
        public int Id { get; set; }
        public string FeeFor { get; set; }
        public decimal SalaryAmount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
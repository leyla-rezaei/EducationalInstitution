namespace EducationalInstitution.Api.Models.Input
{
    public class MiscellaneousExpenseInput
    {
        public string FeeFor { get; set; }
        public decimal SalaryAmount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }
    }
}
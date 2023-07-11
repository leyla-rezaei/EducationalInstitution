namespace EducationalInstitution.Api.Models.Input
{
    public class TransactionInput
    {
        public DateTimeOffset Date { get; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
    }
}
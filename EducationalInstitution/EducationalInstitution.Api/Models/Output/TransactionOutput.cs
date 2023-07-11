namespace EducationalInstitution.Api.Models.Output
{
    public class TransactionOutput
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
    }
}
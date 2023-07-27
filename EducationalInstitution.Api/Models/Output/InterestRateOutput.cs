namespace EducationalInstitution.Api.Models.Output
{
    public class InterestRateOutput
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
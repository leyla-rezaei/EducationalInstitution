namespace EducationalInstitution.Api.Models.Output
{
    public class BankAccountOutput
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Owner { get; set; }
    }
}
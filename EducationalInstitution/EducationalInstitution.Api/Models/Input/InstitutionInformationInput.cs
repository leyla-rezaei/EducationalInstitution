namespace EducationalInstitution.Api.Models.Input
{
    public class InstitutionInformationInput
    {
        public string Name { get; set; }
        public byte[]? ImageLogo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string PostalCode { get; set; }
    }
}
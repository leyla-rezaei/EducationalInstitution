using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class InstitutionInformation : BaseEntity
    {
        public string Name { get; set; }
        public string ImageLogoAddressUrl { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string PostalCode { get; set; }
    }
}
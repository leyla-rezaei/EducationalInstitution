using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class InstitutionInformationInput
    {
        public string Name { get; set; } 
        [Url]
        public string ImageLogoAddressUrl { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [FaxAttribute]
        public string Fax { get; set; }
        [PostalCode]
        public string PostalCode { get; set; }
    }
}

using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public abstract class UserInput
    {
        [RegisterId]
        public string RegisterId { get; set; }
        [Url]
        public string ImageAddressUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        [PhoneNumber]
        public string PhoneNumber { get; set; }
        [MobileNumber]
        public string MobileNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public Gender Gender { get; set; }
    }
}
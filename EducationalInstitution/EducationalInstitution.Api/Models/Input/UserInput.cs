
using EducationalInstitution.Api.Enum;

namespace EducationalInstitution.Api.Models.Input
{
    public abstract class UserInput
    {
        public string ImageAddressUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
    }
}
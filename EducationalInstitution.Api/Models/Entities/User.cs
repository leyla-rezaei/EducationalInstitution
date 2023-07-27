using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class User : BaseEntity
    {
        public string RegisterId { get; set; }
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
        public Education Education { get; set; }


        //Collections
        public ICollection<Message> Messages { get; set; }
    }
}
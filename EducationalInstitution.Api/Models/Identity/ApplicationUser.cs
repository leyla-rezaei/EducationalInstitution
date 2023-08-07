using Microsoft.AspNetCore.Identity;

namespace EducationalInstitution.Api.Models.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    { 
        public bool EmailConfirmed { get; set; }
        public bool MobileNumberConfirmed { get; set; }
        public string Role { get; set; } 
    }
}
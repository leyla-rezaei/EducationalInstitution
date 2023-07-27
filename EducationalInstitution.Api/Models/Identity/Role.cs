using Microsoft.AspNetCore.Identity;

namespace EducationalInstitution.Api.Models.Identity
{
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public bool IsSystemRole { get; set; }
    }
}
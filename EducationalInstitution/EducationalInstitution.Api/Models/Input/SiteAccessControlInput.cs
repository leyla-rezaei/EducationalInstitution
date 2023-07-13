using EducationalInstitution.Api.Enum;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class SiteAccessControlInput
    {
        public bool BasicInformation { get; set; }
        public bool Reporting { get; set; }
        public bool StudentAffairs { get; set; }
        public bool FinancialSector { get; set; }
        public bool Assessment { get; set; }
        public bool RegistrationInformation { get; set; }
        public bool CourseInformation { get; set; }
        public bool ClassInformation { get; set; }
        public bool RelatedAnnouncements { get; set; }
        [Required]
        public UserType UserType { get; set; }
    }
}

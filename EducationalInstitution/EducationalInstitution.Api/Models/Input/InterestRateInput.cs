using EducationalInstitution.Api.Validations;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class InterestRateInput
    {
        [Amount]
        public decimal Amount { get; set; }
        [DataType (DataType.Date)]
        public DateTimeOffset Date { get; set; }
    }
}
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class PaymentOfSalary : BaseEntity
    {
        public decimal SalaryAmount { get; set; }
        public int DepositID { get; set; }
        public DateTimeOffset DepositDate { get; set; }


        //Relations
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class BankAccount : BaseEntity
    {
        public int AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Owner { get; set; }


        //Collections
        public ICollection<Transaction> Transactions { get; set; }  

    }
}
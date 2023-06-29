using EducationalInstitution.Api.Models.Entities;
using EducationalInstitution.Api.Models.Input;
using EducationalInstitution.Api.Repository.Contracts;
using EducationalInstitution.Api.Responses;
using EducationalInstitution.Api.Services.Contracts;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Services
{
    public class TotalBillService : BaseService<TotalBill, TotalBillInput>, ITotalBillService
    {
        public TotalBillService(IBaseRepository<TotalBill> repository) : base(repository)
        { }
        public override SingleResponse<TotalBill> Create(TotalBillInput input)
        {
            if (input == null) return ResponseStatus.Failed;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Create(input);
        }

        public override SingleResponse<TotalBill> Update(int id, TotalBillInput input)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var results = new List<ValidationResult>();

            var resultExist = Validator.TryValidateObject(input, new ValidationContext(input), results, true);

            if (!resultExist) return ResponseStatus.Failed;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            var resultExistPaymentOfSalary = Get<PaymentOfSalary>()
             .Where(x => x.Id == id)
              .Any();

            var resultExistRegistrationInvoice = Get<CourseStudent>()
               .Where(x => x.Id == id)
                .Any();

            if (resultExistPaymentOfSalary || resultExistRegistrationInvoice)
                return ResponseStatus.UnknownError;

            return Delete(id);
        }
    }
}
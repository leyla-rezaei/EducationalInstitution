using EducationalInstitution.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class WithdrawalAmountAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext == null)
                return new ValidationResult("ValidationContext is null.");

            decimal withdrawalAmount = (decimal)value;
            decimal balance = ((Transaction)validationContext.ObjectInstance).Balance;

            if (withdrawalAmount < 0)
                return new ValidationResult($"{validationContext.DisplayName} cannot be negative.");

            if (withdrawalAmount > balance)
                return new ValidationResult($"Withdrawal amount ({withdrawalAmount:c}) cannot be greater than balance ({balance:c}).");

            return ValidationResult.Success;
        }
    }
}
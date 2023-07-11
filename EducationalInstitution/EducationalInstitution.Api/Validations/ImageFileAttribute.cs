using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Validations
{
    public class ImageFileAttribute : ValidationAttribute
    {

        private readonly int _maxFileSize;

        public ImageFileAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            if (value == null)
            {
                return ValidationResult.Success;
            }
            if (!(value is byte[]))
            {
                return new ValidationResult($"the value must be a byte array.");
            }

            byte[] imageBytes = (byte[])value;
            if (imageBytes.Length > _maxFileSize)
            {
                return new ValidationResult($"The byte array exceeds the maximum file size of {_maxFileSize} bytes.");
            }
            return ValidationResult.Success;
        }
    }
}
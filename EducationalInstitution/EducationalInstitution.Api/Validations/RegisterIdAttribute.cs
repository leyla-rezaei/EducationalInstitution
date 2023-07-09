﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EducationalInstitution.Api.Validations
{
    public class RegisterIdAttribute : ValidationAttribute
    {
       
        private readonly HashSet<string> RegisteredIds = new HashSet<string>();

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            Regex regexRegisterId = new Regex(@"^\d{4}$");
            if (!regexRegisterId.IsMatch((string)value))
            {
                return false;
            }
          
            if (CheckDuplicate((string)value))
            {
                ErrorMessage = $"Duplicate register id: {(string)value}"; 
                return false;
            }
           
            RegisteredIds.Add((string)value);

            return true;
        }

       
        private bool CheckDuplicate(string registerId)
        {
            return RegisteredIds.Any(x => x == registerId);
        }
       
      

        public override string FormatErrorMessage(string name)
        {
            return $"Invalid register id.";
        }
    }
}
﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split('@');
            if (strings[1].ToUpper() == AllowedDomain.ToUpper())
            {
                return null;
            }

            return new ValidationResult($"Domain must be {AllowedDomain}",
            new[] { validationContext.MemberName });
        }
    }
}

//Resource: https://www.pragimtech.com/blog/blazor/blazor-custom-form-validation/

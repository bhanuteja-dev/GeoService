using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GeoService.Entities.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ValidAlphaNumeric : ValidationAttribute
    {
        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public override bool IsValid(object value)
        {
            if (((string) value).Length < MinLength)
            {
                return false;
            }

            if (!IsValidAlphanumeric(value))
            {
                return false;
            }

            return ((string) value).Length <= MaxLength;
        }

        private bool IsValidAlphanumeric(object value)
        {
            const string pattern = "^[0-9a-zA-Z]*$";

            return Regex.IsMatch((string) value, pattern);
        }
    }
}
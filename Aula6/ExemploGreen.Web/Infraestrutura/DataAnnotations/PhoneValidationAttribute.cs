using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExemploGreen.Web.Infraestrutura.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class PhoneValidationAttribute : ValidationAttribute
    {
        private readonly Regex phoneRegex = new Regex(@"^\d{4,5}-\d{4}$", RegexOptions.Compiled);

        public PhoneValidationAttribute()
        {
        }

        public PhoneValidationAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public PhoneValidationAttribute(Func<string> errorMessageAccessor) : base(errorMessageAccessor)
        {
        }

        public override bool IsValid(object value)
        {
            if (value is string)
            {
                string candidatoTelefone = (string)value;
                return phoneRegex.IsMatch(candidatoTelefone);
            }
            return false;
        }
    }
}

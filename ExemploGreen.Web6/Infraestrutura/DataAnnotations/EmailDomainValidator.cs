using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Infraestrutura.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class EmailDomainValidator : ValidationAttribute
    {
        private string domain = "@green.com.br";

        public EmailDomainValidator(string domain)
        {
            this.domain = domain;
        }

        public override bool IsValid(object value)
        {
            if (value is string)
            {
                string emailCandidato = (string)value;
                return emailCandidato.EndsWith(domain);
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Infraestrutura.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class SobrenomeValidator : ValidationAttribute
    {
        private readonly string[] sobrenomes = new string[] { "Silva", "Da Silva" };

        public override bool IsValid(object value)
        {
            string candidato = (string)value;

            return sobrenomes.Contains(candidato);
        }
    }
}
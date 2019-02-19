using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploGreen.Web.Infraestrutura.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class NomeValidator : ValidationAttribute
    {
        private readonly string[] nomesPermitidos;

        public string NomeEspecial { get; set; }

        public NomeValidator(string nome1, string nome2)
        {
            nomesPermitidos = new string[] { nome1, nome2 };
        }

        public override bool IsValid(object value)
        {
            string nome = (string)value;
            if (nomesPermitidos.Contains(nome))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra.Validations
{
    public class AllLettersValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string strValue = value as string;

            //caso vazio nao queremos validar
            if (string.IsNullOrEmpty(strValue))
                return true;

            return strValue.All(char.IsLetter);
        }
    }
}

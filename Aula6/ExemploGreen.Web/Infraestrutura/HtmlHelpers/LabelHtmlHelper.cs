using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploGreen.Web.Infraestrutura.HtmlHelpers
{
    public static class LabelHtmlHelper
    {
        public static string Label(this HtmlHelper helper, string target, string text)
        {
            return String.Format("<label for='{0}'>Hello Moto {1}</label>", target, text);
        }
    }
}

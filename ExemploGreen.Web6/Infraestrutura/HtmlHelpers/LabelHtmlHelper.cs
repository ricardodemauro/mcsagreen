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
        public static MvcHtmlString LabelGreen(this HtmlHelper helper, string target, string text)
        {
            string value = string.Format("<label for='{0}'>Hello From Green {1}</label>", target, text);
            return new MvcHtmlString(value);
        }
    }
}

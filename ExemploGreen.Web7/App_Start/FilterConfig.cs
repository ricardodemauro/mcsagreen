using ExemploGreen.Web.Infraestrutura.Filters;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GreenLoggerAttribute());
            filters.Add(new FiltroDoLucas());
        }
    }
}

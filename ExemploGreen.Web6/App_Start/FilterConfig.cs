using ExemploGreen.Web.Infraestrutura.Filters;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogActionFilter());
            //filters.Add(new AuthorizeAttribute());
            //filters.Add(new RequireHttpsAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}

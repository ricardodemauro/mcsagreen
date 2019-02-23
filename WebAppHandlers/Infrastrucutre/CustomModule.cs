using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebAppHandlers.Infrastrucutre
{
    public class CustomModule : IHttpModule
    {
        public CustomModule()
        {
        }

        public string ModuleName
        {
            get { return "CustomModule"; }
        }

        public void Dispose()
        {

        }

        public void Init(HttpApplication application)
        {
            application.BeginRequest += Application_BeginRequest;
            application.EndRequest += Application_EndRequest;
        }

        private void Application_EndRequest(object sender, EventArgs e)
        {
            var application = sender as HttpApplication;
            if (application != null)
            {
                var ctx = application.Context;
                if (ctx.Request.RawUrl.EndsWith("/"))
                {
                    application.Context.Response.Write("<h1>good bye from module</h1>");
                }
            }
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            var application = sender as HttpApplication;
            if (application != null)
            {
                HttpContext ctx = application.Context;
                if (ctx.Request.RawUrl.EndsWith("/"))
                {
                    application.Context.Response.Write("<h1>Hello from module</h1>");
                }
            }
        }
    }
}

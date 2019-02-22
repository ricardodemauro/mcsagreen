using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppHandlers.Infrastrucutre
{
    /// <summary>
    /// Summary description for SomeHandler
    /// </summary>
    public class SomeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
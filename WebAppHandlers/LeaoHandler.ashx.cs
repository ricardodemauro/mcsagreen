using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAppHandlers
{
    /// <summary>
    /// Summary description for LeaoHandler
    /// </summary>
    public class LeaoHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/png";
            string path = @"C:\Users\Admin\files\mcsagreen\WebAppHandlers\google-chrome.png";
            byte[] img = File.ReadAllBytes(path);

            context.Response.BinaryWrite(img);
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
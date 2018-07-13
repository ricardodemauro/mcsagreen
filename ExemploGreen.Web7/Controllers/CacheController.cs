using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploGreen.Web.Controllers
{
    public class CacheController : Controller
    {
        [OutputCache(CacheProfile = "CP1")]
        public string CacheActionProfile(string param1)
        {
            //HttpContext.Cache["dskdksdksdksdksd"] = "weweweew";

            return $"Cached data {DateTime.Now.ToString()} - Param1 {param1}";
        }

        [OutputCache(Duration = 60,
            Location = System.Web.UI.OutputCacheLocation.Server,
            NoStore = true)]
        public string CacheAction()
        {
            return $"Cached data {DateTime.Now.ToString()}";
        }

        public string AddCookieData()
        {
            ControllerContext.HttpContext.Response.Cookies.Add(new HttpCookie("cookie", "value"));
            return "cookie";
        }

        public string CookieData()
        {
            return $"Cookie Value: {Request.Cookies["mycookie"]}";
        }

        public string AddCacheData()
        {
            HttpContext.Cache["CacheKey"] = "Cache data";

            string data = (string)HttpContext.Cache["CacheKey"];

            return data;
        }

        public string CacheData()
        {
            HttpContext.Cache["CacheKey"] = "Cache data";

            string data = (string)HttpContext.Cache["CacheKey"];

            return data;
        }

        public string AddApplicationData()
        {
            HttpContext.Application.Lock();
            HttpContext.Application["Name"] = "Value";
            HttpContext.Application.UnLock();
            var appValue = (string)HttpContext.Application["Name"];
            return appValue;
        }

        public string ApplicationData()
        {
            var appValue = (string)HttpContext.Application["Name"];
            return appValue;
        }

        public string AddSessionData()
        {
            Session["S1"] = "session s1";
            Session.Add("S2", "session s2");
            return string.Format("S1 {0} S2 {1}", Session["S1"], Session["S2"]);
        }

        public string SessionData()
        {
            return string.Format("S1 {0} S2 {1}", Session["S1"], Session["S2"]);
        }

        public string AbadonaSession()
        {
            Session.Abandon();
            return "Ok";
        }
    }
}
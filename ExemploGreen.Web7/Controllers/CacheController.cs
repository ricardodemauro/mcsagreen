using ExemploGreen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;

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
            Location = OutputCacheLocation.Server, VaryByParam = "name")]
        public string CacheAction(string name)
        {
            return $"Cached data {DateTime.Now.ToString()} - {name}";
        }

        public string AddCookieData()
        {
            Response.Cookies.Add(new HttpCookie("mycookie", "value"));
            return "cookie";
        }

        public string CookieData()
        {
            return $"Cookie Value: {Request.Cookies["mycookie"].Value}";
        }

        public string AddCacheData()
        {
            HttpContext.Cache["CacheKey"] = "Cache data";

            HttpContext.Cache.Add("CacheKey",
                new Cliente(),
                null,
                DateTime.Now.AddMinutes(10),
                TimeSpan.MinValue, 
                CacheItemPriority.Normal, 
                null);

            HttpContext.Cache.Remove("CacheKey");

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
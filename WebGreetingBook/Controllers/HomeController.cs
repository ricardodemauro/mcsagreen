using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebGreetingBook.Models;

namespace WebGreetingBook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Counter()
        {
            int? counter = HttpContext.Session.GetInt32("Couter");

            if (!counter.HasValue)
            {
                counter = 0;
            }

            counter++;

            HttpContext.Session.SetInt32("Couter", counter.Value);
            return Ok(counter.Value);
        }

        public IActionResult TimeNow([FromServices] IMemoryCache cache)
        {
            DateTime time = DateTime.MinValue;

            if (!cache.TryGetValue("Time", out time))
            {
                MemoryCacheEntryOptions options = new MemoryCacheEntryOptions();

                time = DateTime.Now;

                cache.Set("Time", time);
            }
            return Ok(time);
        }

        public IActionResult RemoveCache([FromServices] IMemoryCache cache)
        {
            var itemCache = cache.Get("Time");
            cache.Remove(itemCache);
            return Ok();
        }

        public IActionResult Greeting()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

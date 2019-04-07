using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTodos.Infra;
using WebTodos.Models;

namespace WebTodos.Controllers
{
    public class HomeController : Controller
    {
        [AddHeaderFactory]
        public IActionResult Index()
        {
            return View();
        }

        //[ShortCircuitingResourceFilter]
        [AddHeaderResultFilter("Bla", "Hahahaha")]
        public IActionResult Privacy()
        {
            return View();
        }

        [CustomExceptionFilter]
        public IActionResult ExceptionOk()
        {
            throw new NotImplementedException();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

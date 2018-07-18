using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Green.Alunos.Controllers
{
    public class ErrorsController : Controller
    {
        public string NotFound()
        {
            return "Ops! Nao eh aqui";
        }

        public string InternalServerError()
        {
            return "Ops! Deu erro";
        }

        public string DefaultError()
        {
            return "Hello from default error";
        }
    }
}
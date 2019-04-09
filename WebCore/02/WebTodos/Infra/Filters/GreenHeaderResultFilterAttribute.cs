using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTodos.Infra.Filters
{
    public class GreenHeaderResultFilterAttribute : ResultFilterAttribute
    {
        /*
         * Desafio:
- Criar filtro que escreve no header como chave-valor
Chave: Green
Valor: se Home/Index "Home", se Home/Privacy "Privacy", senão nao faz nada
         */

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            string controller = context.ActionDescriptor.RouteValues["Controller"];
            string action = context.ActionDescriptor.RouteValues["Action"];

            string headerKey = "Green-NP";
            string headerValue = string.Empty;
            if (controller == "Home" && action == "Index")
                headerValue = "Index";
            else if (controller == "Home" && action == "Privacy")
                headerValue = "Privacy";

            context.HttpContext.Response.Headers.Add(headerKey, new string[] { headerValue });
            base.OnResultExecuting(context);
        }
    }
}

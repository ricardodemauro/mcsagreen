using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class AddHeaderResultFilterAttribute : ResultFilterAttribute, IResultFilter
    {
        private readonly string _name;

        private readonly string _value;

        public AddHeaderResultFilterAttribute(string name, string @value)
        {
            _name = name;
            _value = @value;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add(_name, new string[] { _value });
            base.OnResultExecuting(context);
        }
    }
}

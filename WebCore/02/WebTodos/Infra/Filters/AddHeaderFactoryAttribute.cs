using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class AddHeaderFactoryAttribute : Attribute, IFilterFactory
    {
        public bool IsReusable => false;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return new AddHeaderResultFilterAttribute("Green", "MCSA-Web");
        }
    }
}

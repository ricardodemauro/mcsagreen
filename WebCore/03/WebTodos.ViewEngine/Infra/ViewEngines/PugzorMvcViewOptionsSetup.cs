using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.ViewEngine.Infra.ViewEngines
{
    public class PugzorMvcViewOptionsSetup : IConfigureOptions<MvcViewOptions>
    {
        private readonly PugzorViewEngine _pugzorViewEngine;

        public PugzorMvcViewOptionsSetup(PugzorViewEngine pugzorViewEngine)
        {
            _pugzorViewEngine = pugzorViewEngine ?? throw new ArgumentNullException(nameof(pugzorViewEngine));
        }

        public void Configure(MvcViewOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.ViewEngines.Add(_pugzorViewEngine);
        }
    }
}

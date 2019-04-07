using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.NodeServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.ViewEngine.Infra.ViewEngines
{
    public class PugzorView : IView
    {
        private readonly string _path;
        private readonly PugRendering _pugRendering;

        public PugzorView(string path, PugRendering pugRendering)
        {
            _path = path;
            _pugRendering = pugRendering;
        }

        public string Path => _path;

        public async Task RenderAsync(ViewContext context)
        {
            var result = await _pugRendering.Render(new FileInfo(Path), context.ViewData.Model, context.ViewData, context.ModelState).ConfigureAwait(false);
            context.Writer.Write(result);
        }
    }
}

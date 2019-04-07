using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.ViewEngine.Infra.ViewEngines
{
    public class PugzorViewEngine : IViewEngine
    {
        private readonly PugRendering _pugRendering;
        private readonly PugzorViewEngineOptions _options;

        public PugzorViewEngine(PugRendering pugRendering, IOptions<PugzorViewEngineOptions> optionsAccessor)
        {
            _options = optionsAccessor?.Value ?? throw new ArgumentNullException(nameof(optionsAccessor));
            _pugRendering = pugRendering;
        }

        public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
        {
            var controllerName = GetNormalizedRouteValue(context, "controller");
            var areaName = GetNormalizedRouteValue(context, "area");

            var checkedLocations = new List<string>();
            foreach (var location in _options.ViewLocationFormats)
            {
                var view = string.Format(location, viewName, controllerName);
                if (File.Exists(view))
                {
                    // ReSharper disable once Mvc.ViewNotResolved
                    return ViewEngineResult.Found("Default", new PugzorView(view, _pugRendering));
                }
                checkedLocations.Add(view);
            }

            return ViewEngineResult.NotFound(viewName, checkedLocations);
        }

        public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
        {
            var applicationRelativePath = PathHelper.GetAbsolutePath(executingFilePath, viewPath);

            if (!PathHelper.IsAbsolutePath(viewPath))
            {
                // Not a path this method can handle.
                return ViewEngineResult.NotFound(applicationRelativePath, Enumerable.Empty<string>());
            }

            // ReSharper disable once Mvc.ViewNotResolved
            return ViewEngineResult.Found("Default", new PugzorView(applicationRelativePath, _pugRendering));
        }

        public static string GetNormalizedRouteValue(ActionContext context, string key)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (!context.RouteData.Values.TryGetValue(key, out object routeValue))
            {
                return null;
            }

            string normalizedValue = null;
            if (context.ActionDescriptor.RouteValues.TryGetValue(key, out string value) && !string.IsNullOrEmpty(value))
            {
                normalizedValue = value;
            }

            var stringRouteValue = routeValue?.ToString();
            return string.Equals(normalizedValue, stringRouteValue, StringComparison.OrdinalIgnoreCase) ? normalizedValue : stringRouteValue;
        }
    }
}

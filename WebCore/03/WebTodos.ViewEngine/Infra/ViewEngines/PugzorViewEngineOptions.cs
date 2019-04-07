using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.ViewEngine.Infra.ViewEngines
{
    public class PugzorViewEngineOptions
    {
        public IList<string> ViewLocationFormats { get; } = new List<string>();
        public string BaseDir { get; set; }
        public bool Pretty { get; set; }
    }
}

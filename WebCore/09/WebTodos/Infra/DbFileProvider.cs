using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class DbFileProvider : IFileProvider
    {
        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            return DbDirectoryContents.Create(subpath);
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            return DbDirectoryContents.Create(subpath).File(subpath);
        }

        public IChangeToken Watch(string filter)
        {
            throw new NotImplementedException();
        }
    }
}

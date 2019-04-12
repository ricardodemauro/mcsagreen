using Microsoft.Extensions.FileProviders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class DbDirectoryContents : List<IFileInfo>, IDirectoryContents
    {
        private readonly string _path;

        bool IDirectoryContents.Exists => string.Compare(_path, "db", true) == 0;

        public DbDirectoryContents(string path)
        {
            _path = path;
        }

        public IFileInfo File(string file)
        {
            throw new NotImplementedException();
        }

        internal static DbDirectoryContents Create(string path)
        {
            return new DbDirectoryContents(path);
        }
    }
}

using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class DbFileInfo : IFileInfo
    {
        public DbFileInfo()
        {

        }

        public Stream CreateReadStream()
        {
            throw new NotImplementedException();
        }

        public bool Exists { get; }

        public long Length { get; }

        public string PhysicalPath { get; }

        public string Name { get; }

        public DateTimeOffset LastModified { get; }

        public bool IsDirectory { get; }
    }
}

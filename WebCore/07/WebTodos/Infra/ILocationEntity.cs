using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public interface ILocationEntity
    {
        decimal Longitude { get; }

        decimal Latitude { get; }
    }
}

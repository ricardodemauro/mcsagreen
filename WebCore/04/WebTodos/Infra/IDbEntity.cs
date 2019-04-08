using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public interface IDbEntity
    {
        Guid Id { get; set; }
    }
}

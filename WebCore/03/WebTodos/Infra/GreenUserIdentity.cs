using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTodos.Infra
{
    public class GreenUserIdentity
    {
        public bool IsAuthenticated()
        {
            return true;
        }
    }
}

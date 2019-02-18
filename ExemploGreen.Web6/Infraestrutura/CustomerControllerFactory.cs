using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace ExemploGreen.Web.Infraestrutura
{
    public class CustomerControllerFactory : IControllerFactory
    {
        private readonly IControllerFactory _default = new DefaultControllerFactory();

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            return _default.CreateController(requestContext, controllerName);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return _default.GetControllerSessionBehavior(requestContext, controllerName);
        }

        public void ReleaseController(IController controller)
        {
            _default.ReleaseController(controller);
        }
    }
}

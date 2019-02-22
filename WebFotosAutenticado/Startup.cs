using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFotosAutenticado.Startup))]
namespace WebFotosAutenticado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

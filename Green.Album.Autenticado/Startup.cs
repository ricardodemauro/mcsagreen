using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Green.Album.Autenticado.Startup))]
namespace Green.Album.Autenticado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

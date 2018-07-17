using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Green.Autenticacao.Startup))]
namespace Green.Autenticacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

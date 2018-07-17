using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Green.Alunos.Startup))]
namespace Green.Alunos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

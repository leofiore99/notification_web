using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotificacaoWebApp.Startup))]
namespace NotificacaoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

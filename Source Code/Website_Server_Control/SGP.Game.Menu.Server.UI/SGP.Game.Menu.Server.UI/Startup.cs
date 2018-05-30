using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGP.Game.Menu.Server.UI.Startup))]
namespace SGP.Game.Menu.Server.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

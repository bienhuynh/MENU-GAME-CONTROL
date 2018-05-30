using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGP.HCBBOOK.CloudServer.UI.Startup))]
namespace SGP.HCBBOOK.CloudServer.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

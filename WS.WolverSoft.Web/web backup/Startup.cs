using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WS.WolverSoft.Web.Startup))]
namespace WS.WolverSoft.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Blef.WebApp.Startup))]

namespace Blef.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRMvc2.Startup))]
namespace SignalRMvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}

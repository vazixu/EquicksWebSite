using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EquicksWeb.Startup))]
namespace EquicksWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

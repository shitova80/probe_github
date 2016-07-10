using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(probe_mvc.Startup))]
namespace probe_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

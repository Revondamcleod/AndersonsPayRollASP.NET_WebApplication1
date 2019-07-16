using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndersonsPayRollASP.NET_WebApplication1.Startup))]
namespace AndersonsPayRollASP.NET_WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

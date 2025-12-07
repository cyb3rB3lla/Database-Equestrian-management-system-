using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hourses.Startup))]
namespace Hourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

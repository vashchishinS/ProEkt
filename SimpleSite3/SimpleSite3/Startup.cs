using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSite3.Startup))]
namespace SimpleSite3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

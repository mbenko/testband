using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myBandSite.Startup))]
namespace myBandSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

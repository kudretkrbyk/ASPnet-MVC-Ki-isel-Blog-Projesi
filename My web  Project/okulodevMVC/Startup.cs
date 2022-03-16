using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(okulodevMVC.Startup))]
namespace okulodevMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dylan.Peng.DemoMVC.Startup))]
namespace Dylan.Peng.DemoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

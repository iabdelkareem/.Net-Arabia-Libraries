using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoMvc.Startup))]
namespace DemoMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

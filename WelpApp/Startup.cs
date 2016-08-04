using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WelpApp.Startup))]
namespace WelpApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

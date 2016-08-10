using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Welp.Startup))]
namespace Welp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

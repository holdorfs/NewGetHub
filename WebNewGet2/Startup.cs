using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNewGet2.Startup))]
namespace WebNewGet2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

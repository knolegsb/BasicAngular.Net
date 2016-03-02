using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicAngular.Net.Startup))]
namespace BasicAngular.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

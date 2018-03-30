using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proje.Startup))]
namespace proje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

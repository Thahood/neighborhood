using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(neighborhood.Startup))]
namespace neighborhood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveMemes.Startup))]
namespace LiveMemes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(musicStore.Startup))]
namespace musicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

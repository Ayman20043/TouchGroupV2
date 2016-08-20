using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TouchGroupV2.Startup))]
namespace TouchGroupV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

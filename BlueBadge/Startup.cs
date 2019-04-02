using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlueBadge.Startup))]
namespace BlueBadge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

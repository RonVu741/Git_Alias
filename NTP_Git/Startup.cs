using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NTP_Git.Startup))]
namespace NTP_Git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

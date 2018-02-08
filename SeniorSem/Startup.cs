using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeniorSem.Startup))]
namespace SeniorSem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

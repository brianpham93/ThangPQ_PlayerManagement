using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThangPQ_PlayerManagement.Startup))]
namespace ThangPQ_PlayerManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

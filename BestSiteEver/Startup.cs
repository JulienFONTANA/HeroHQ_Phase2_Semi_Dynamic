using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestSiteEver.Startup))]
namespace BestSiteEver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

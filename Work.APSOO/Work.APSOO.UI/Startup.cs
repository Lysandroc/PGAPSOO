using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Work.APSOO.UI.Startup))]
namespace Work.APSOO.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

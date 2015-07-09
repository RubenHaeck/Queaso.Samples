using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Queaso.Northwind.Site.Startup))]
namespace Queaso.Northwind.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

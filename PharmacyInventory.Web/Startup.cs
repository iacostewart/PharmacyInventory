using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PharmacyInventory.Web.Startup))]
namespace PharmacyInventory.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

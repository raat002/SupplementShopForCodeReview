using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupplementShop.Startup))]
namespace SupplementShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerShopApp.Startup))]
namespace FlowerShopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_ecommerce.Startup))]
namespace aspnet_ecommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

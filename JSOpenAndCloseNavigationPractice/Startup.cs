using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSOpenAndCloseNavigationPractice.Startup))]
namespace JSOpenAndCloseNavigationPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

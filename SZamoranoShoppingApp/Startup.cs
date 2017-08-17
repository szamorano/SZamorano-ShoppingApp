using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SZamoranoShoppingApp.Startup))]
namespace SZamoranoShoppingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

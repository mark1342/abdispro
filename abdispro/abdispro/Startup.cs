using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(abdispro.Startup))]
namespace abdispro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

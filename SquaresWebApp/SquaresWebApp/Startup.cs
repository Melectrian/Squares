using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SquaresWebApp.Startup))]
namespace SquaresWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

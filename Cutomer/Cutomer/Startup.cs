using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cutomer.Startup))]
namespace Cutomer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSAS.Startup))]
namespace CSAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

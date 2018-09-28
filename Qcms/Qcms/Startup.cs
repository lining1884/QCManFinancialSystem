using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Qcms.Startup))]
namespace Qcms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

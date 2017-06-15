using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiAzure.Startup))]
namespace HiAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

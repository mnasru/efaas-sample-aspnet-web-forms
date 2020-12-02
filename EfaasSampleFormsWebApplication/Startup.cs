using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EfaasSampleFormsWebApplication.Startup))]
namespace EfaasSampleFormsWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

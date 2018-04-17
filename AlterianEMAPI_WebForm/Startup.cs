using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlterianEMAPI_WebForm.Startup))]
namespace AlterianEMAPI_WebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

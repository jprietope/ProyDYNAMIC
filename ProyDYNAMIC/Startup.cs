using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyDYNAMIC.Startup))]
namespace ProyDYNAMIC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

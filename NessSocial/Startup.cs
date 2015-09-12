using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NessSocial.Startup))]
namespace NessSocial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAngularCRUD.Startup))]
namespace MVCAngularCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

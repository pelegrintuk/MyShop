using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWeb.MVC.Startup))]
namespace MyWeb.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

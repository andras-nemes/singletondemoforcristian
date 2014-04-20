using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingletonMVC.Startup))]
namespace SingletonMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

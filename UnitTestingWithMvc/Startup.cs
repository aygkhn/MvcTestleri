using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitTestingWithMvc.Startup))]
namespace UnitTestingWithMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

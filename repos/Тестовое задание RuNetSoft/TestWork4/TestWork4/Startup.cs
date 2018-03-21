using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWork4.Startup))]
namespace TestWork4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

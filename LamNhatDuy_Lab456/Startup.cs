using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamNhatDuy_Lab456.Startup))]
namespace LamNhatDuy_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

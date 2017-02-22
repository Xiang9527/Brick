using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brick.Startup))]
namespace Brick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

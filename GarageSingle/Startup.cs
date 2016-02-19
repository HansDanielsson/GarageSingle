using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GarageSingle.Startup))]
namespace GarageSingle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

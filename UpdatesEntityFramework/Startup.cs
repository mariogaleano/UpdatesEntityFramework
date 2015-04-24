using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpdatesEntityFramework.Startup))]
namespace UpdatesEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

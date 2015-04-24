using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFWebClient.Startup))]
namespace EFWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

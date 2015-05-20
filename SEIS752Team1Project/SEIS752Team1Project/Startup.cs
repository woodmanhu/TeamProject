using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEIS752Team1Project.Startup))]
namespace SEIS752Team1Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
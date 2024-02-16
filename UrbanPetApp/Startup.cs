using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrbanPetApp.Startup))]
namespace UrbanPetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

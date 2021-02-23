using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5204_mypassion_project_n1010101010.Startup))]
namespace _5204_mypassion_project_n1010101010
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

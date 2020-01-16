using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(groupCapstoneMusic.Startup))]
namespace groupCapstoneMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

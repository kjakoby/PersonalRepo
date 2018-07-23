using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreatureArena.UI.Startup))]
namespace CreatureArena.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

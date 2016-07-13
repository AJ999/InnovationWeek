using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InnovationWeek.Startup))]
namespace InnovationWeek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

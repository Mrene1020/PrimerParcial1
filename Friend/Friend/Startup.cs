using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Friend.Startup))]
namespace Friend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingo.Startup))]
namespace shoppingo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
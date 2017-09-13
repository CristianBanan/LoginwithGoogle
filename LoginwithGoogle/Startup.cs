using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginwithGoogle.Startup))]
namespace LoginwithGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

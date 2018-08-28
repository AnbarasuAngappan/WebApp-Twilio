using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_Twilio.Startup))]
namespace WebApp_Twilio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

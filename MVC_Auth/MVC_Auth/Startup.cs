using Microsoft.Owin;
using Owin;
using System.Web.Helpers;

[assembly: OwinStartupAttribute(typeof(MVC_Auth.Startup))]
namespace MVC_Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			AntiForgeryConfig.CookieName = "__RequestVerificationToken_L012Y19hdXRoMg2";

		}
    }
}

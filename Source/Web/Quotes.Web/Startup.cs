using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(Quotes.Web.Startup))]

namespace Quotes.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}

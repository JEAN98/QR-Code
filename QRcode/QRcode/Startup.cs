using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QRcode.Startup))]
namespace QRcode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

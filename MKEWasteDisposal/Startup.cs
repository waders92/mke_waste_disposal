using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MKEWasteDisposal.Startup))]
namespace MKEWasteDisposal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

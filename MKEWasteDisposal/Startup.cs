using Microsoft.Owin;
using MKEWasteDisposal.Models;
using Owin;
using Stripe;

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

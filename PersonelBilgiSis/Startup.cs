using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonelBilgiSis.Startup))]
namespace PersonelBilgiSis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

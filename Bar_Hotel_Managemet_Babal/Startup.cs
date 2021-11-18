using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bar_Hotel_Managemet_Babal.Startup))]
namespace Bar_Hotel_Managemet_Babal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

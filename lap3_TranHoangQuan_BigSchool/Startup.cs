using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lap3_TranHoangQuan_BigSchool.Startup))]
namespace lap3_TranHoangQuan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

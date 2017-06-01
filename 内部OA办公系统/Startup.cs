using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(内部OA办公系统.Startup))]
namespace 内部OA办公系统
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

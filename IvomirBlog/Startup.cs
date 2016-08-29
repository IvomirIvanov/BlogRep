using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IvomirBlog.Startup))]
namespace IvomirBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

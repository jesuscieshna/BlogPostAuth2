using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogPostV3.Startup))]
namespace BlogPostV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QAProject.Startup))]
namespace QAProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

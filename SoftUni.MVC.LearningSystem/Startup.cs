using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftUni.MVC.LearningSystem.Web.Startup))]
namespace SoftUni.MVC.LearningSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

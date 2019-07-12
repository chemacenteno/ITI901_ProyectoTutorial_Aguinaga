using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITI901_ProyectoTutorial_Aguinaga.Startup))]
namespace ITI901_ProyectoTutorial_Aguinaga
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

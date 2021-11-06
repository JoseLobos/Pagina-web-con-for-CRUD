using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pagina_web_sistema_de_ventas.Startup))]
namespace Pagina_web_sistema_de_ventas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

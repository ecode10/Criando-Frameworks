using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VerificacaoDeFormulario.Startup))]
namespace VerificacaoDeFormulario
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

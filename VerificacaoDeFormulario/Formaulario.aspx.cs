using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.UCB.Framework.Util;

namespace VerificacaoDeFormulario
{
    public partial class Formaulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert('abasteça');</script> ");
            var a = new Combustivel().calcularGasolinaEAlcool(3.95);
            
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToInt32("12");
            var dataDoDia = Convert.ToDateTime("20/03/2017");

            if (Page.IsValid)//se a página for validade pelo required...
            {
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EN = upb.tabd.entidades;
using CT = upb.tabd.controladora;


namespace MascotasWEB
{
    public partial class ConsultaMascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRaza_Click(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int idRaza = -1;
            if (txtRaza.Text.Length != 0)
            {
                idRaza = int.Parse(txtRaza.Text);
            }
            ConsultarRazas(idRaza);
        }

        private void ConsultarRazas( int idRaza)
        {
            CT.Raza raza = new CT.Raza();
            List<EN.Raza> listaResultado = raza.ConsultarRaza(idRaza);

            gvRazas.DataSource = listaResultado;
            gvRazas.DataBind();
        }
    }
}
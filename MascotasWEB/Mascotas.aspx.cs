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
    public partial class Mascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string idMascota = tbBuscar.Text;
            if (idMascota.Trim().Length == 0)
            {
                idMascota = "-1";
            }
            ConsultarMascotas(int.Parse(idMascota));
        }
        private void ConsultarMascotas(int idMascota)
        {
            CT.Mascota controladora = new CT.Mascota();
            List<EN.Mascota> listado = controladora.ConsultarMascotas(idMascota);
            gvMascotas.DataSource = listado;
            gvMascotas.DataBind();
        }

    }
}
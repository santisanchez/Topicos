using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR = upb.tabd.broker;
using EN = upb.tabd.entidades;

namespace upb.tabd.controladora
{
    public class Especie
    {
        public BR.BDMascotasEntities db = new BR.BDMascotasEntities();

        public List<EN.Especies> ConsultarEspecie()
        {
            List<EN.Especies> listadoEspecies = new List<EN.Especies>();

            try
            {

                var resultado = from e in db.Especies
                                select new { e.IdEspecie, e.Especie1 };

                foreach (var item in resultado)
                {
                    EN.Especies especie = new EN.Especies();


                    especie.IdEspecie = int.Parse(item.IdEspecie.ToString());
                    especie.NombreEspecie = item.Especie1;

                    listadoEspecies.Add(especie);


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listadoEspecies;
        }

    }
}

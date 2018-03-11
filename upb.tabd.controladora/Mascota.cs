using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN = upb.tabd.entidades;
using BR = upb.tabd.broker;

namespace upb.tabd.controladora
{
    public class Mascota
    {
        public BR.BDMascotasEntities db = new BR.BDMascotasEntities();

        public List<EN.Mascota> ConsultarMascotas(int idMascota)
        {
            List<EN.Mascota> listadoMascotas = new List<EN.Mascota>();

            try
            {

                var resultado = from m in db.Mascotas
                                join r in db.Razas on m.IdentRaza equals r.IdentRaza
                                join e in db.Especies on m.IdentEspecie equals e.IdEspecie
                                join c in db.Clientes on m.IdentCliente equals c.IdentCliente
                                where (m.IdentMascota == idMascota || idMascota == -1)
                                select new
                                { m.IdentMascota, m.NombreMascota, r.IdentRaza, r.NombreRaza, e.IdEspecie, e.Especie1, c.IdentCliente, c.NombreCliente };// falta identespecie especie identcleinte cliente

                foreach (var item in resultado)
                {
                    EN.Mascota mascota = new EN.Mascota();
                    mascota.raza = new EN.Raza();
                    mascota.especie = new EN.Especies();
                    mascota.cliente = new EN.Cliente();
                    mascota.raza.IdRaza = int.Parse(item.IdentRaza.ToString());
                    mascota.raza.NombreRaza = item.NombreRaza;
                    mascota.especie.IdEspecie = int.Parse(item.IdEspecie.ToString());
                    mascota.especie.NombreEspecie = item.Especie1;
                    mascota.cliente.IdentCliente = int.Parse(item.IdentCliente.ToString());
                    mascota.cliente.NombreCliente = item.NombreCliente;
                    mascota.identMascota = int.Parse(item.IdentMascota.ToString());
                    mascota.NombreMascota = item.NombreMascota;

                    listadoMascotas.Add(mascota);


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listadoMascotas;
        }
        public bool ActualizarMascota(EN.Mascota mascota)
        {
            bool resultado = false;
            try
            {

                BR.Mascota objMascota = db.Mascotas.Where(x => x.IdentMascota == mascota.identMascota).FirstOrDefault();

                BR.Cliente objCliente = db.Clientes.Where(x => x.IdentCliente == mascota.cliente.IdentCliente).FirstOrDefault();
                BR.Raza objRaza = db.Razas.Where(x => x.IdentRaza == mascota.raza.IdRaza).FirstOrDefault();
                BR.Especie objEspecie = db.Especies.Where(x => x.IdEspecie == mascota.especie.IdEspecie).FirstOrDefault();


                objMascota.NombreMascota = mascota.NombreMascota;
                objMascota.Cliente = objCliente;
                objMascota.Especie = objEspecie;
                objMascota.Raza = objRaza;

                db.SaveChanges();
                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }
        public bool CrearMascota(EN.Mascota mascota)
        {
            bool resultado = false;
            try
            {

                BR.Mascota objMascota = new BR.Mascota();
                BR.Cliente objCliente = db.Clientes.Where(x => x.IdentCliente == mascota.cliente.IdentCliente).FirstOrDefault();
                BR.Raza objRaza = db.Razas.Where(x => x.IdentRaza == mascota.raza.IdRaza).FirstOrDefault();
                BR.Especie objEspecie = db.Especies.Where(x => x.IdEspecie == mascota.especie.IdEspecie).FirstOrDefault();



                objMascota.IdentMascota = int.Parse(mascota.identMascota.ToString());
                objMascota.NombreMascota = mascota.NombreMascota;
                objMascota.Cliente = objCliente;
                objMascota.Especie = objEspecie;
                objMascota.Raza = objRaza;

                //objMascota.Raza.IdentRaza = mascota.raza.identRaza;
                //objMascota.Raza.NombreRaza = mascota.raza.nombreRaza;
                //objMascota.Especy.IdentEspecie = mascota.especie.identEspecie;
                //objMascota.Especy.NombreEspecie = mascota.especie.nombreEspecie;

                db.Mascotas.Add(objMascota);
                db.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;

            }
            return resultado;
        }

        public bool EliminarMascota(double identificacion)
        {
            bool resultado = false;
            try
            {

                BR.Mascota objMascota = db.Mascotas.Where(x => x.IdentMascota == identificacion).FirstOrDefault();

                db.Mascotas.Remove(objMascota);
                db.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return resultado;
        }

    }
}


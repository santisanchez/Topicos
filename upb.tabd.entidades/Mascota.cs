using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upb.tabd.entidades
{
    public class Mascota
    {
        public double identMascota { get; set; }
        public String NombreMascota { get; set; }

        public Raza raza { get; set; }
        public Especies especie { get; set; }
        public Cliente cliente { get; set; }
    }
}

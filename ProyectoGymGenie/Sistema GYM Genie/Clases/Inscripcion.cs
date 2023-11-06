using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Inscripcion
    {
        public int id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteDNI_Persona { get; set; }
        public virtual Clase Clase { get; set; }
        public int ClaseId { get; set; }

        public string NombreClase { get
            {
                return "Nombre: " + Clase.NombreClase + "\nCosto: $" + Clase.CostoClase;
            }
        }

    }
}






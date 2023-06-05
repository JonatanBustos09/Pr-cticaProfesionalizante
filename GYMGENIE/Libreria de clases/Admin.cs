using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Admin : Persona
    {
        public int idAdmin { get; set; }

        public string Direccion { get; set; } // se entiende que comprende calle numero y localidad

    }
}

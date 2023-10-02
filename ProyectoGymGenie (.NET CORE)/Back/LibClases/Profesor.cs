using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.LibClases
{
    public class Profesor : Persona
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
    }
}

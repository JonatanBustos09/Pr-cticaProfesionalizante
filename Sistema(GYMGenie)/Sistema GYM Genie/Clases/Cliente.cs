using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }
        public float PesoCliente { get; set; }
        public int AlturaCm { get; set; }
    }
}

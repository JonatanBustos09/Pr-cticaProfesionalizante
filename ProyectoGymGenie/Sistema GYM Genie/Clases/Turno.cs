using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public DateTime DiaTurno { get; set; }
        public DateTime HoraInicioTurno { get; set; }
        public DateTime HoraFinTurno { get; set; }
    }
}

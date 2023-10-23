using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class ReservaTurno
    {
        public int ReservaId { get; set; }
        public Reserva? Reserva { get; set; }
        public int TurnoId { get; set; }
        public Turno? Turno { get; set; }
    }
}

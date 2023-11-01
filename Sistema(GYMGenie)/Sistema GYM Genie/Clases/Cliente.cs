using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public int DNICliente { get; set; }
        [MaxLength(25)]
        public string? NombreCliente { get; set; }
        [MaxLength(25)]
        public string? ApellidoCliente { get; set; }
        [MaxLength(25)]
        public string? TelefonoCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(50)]
        public string? Direccion { get; set; }
        public float PesoCliente { get; set; }
        public int AlturaCm { get; set; }

    }

}

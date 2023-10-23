using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public int DNI_Persona { get; set; }
        public string? NombrePersona { get; set; }
        public string? ApellidoPersona { get; set; }
        public int? TelefonoPersona { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contrasenia { get; set; }
        public string? Ciudad { get; set; }
        public string? Direccion { get; set; }
        public int AlturaDireccion { get; set; }
    }
}

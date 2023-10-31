using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public int DNI_Persona { get; set; }
        [MaxLength(25)]
        public string? NombrePersona { get; set; }
        [MaxLength(25)]
        public string? ApellidoPersona { get; set; }
        public int? TelefonoPersona { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(50)]
        public string? CorreoElectronico { get; set; }
        [MaxLength(25)]
        public string? NombreUsuario { get; set; }
        [MaxLength(30)]
        public string? Contrasenia { get; set; }
        [MaxLength(25)]
        public string? Ciudad { get; set; }
        [MaxLength(25)]
        public string? Direccion { get; set; }
        public int AlturaDireccion { get; set; }
        public bool Profesor { get;set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Clase
    {
        public int ClaseId { get; set; }
        [MaxLength(25)]
        public string? NombreClase { get; set; }
        [MaxLength(100)]
        public string? Equipamiento { get; set; }
        public float CostoClase { get; set; }
        public int? ProfesorDNI { get; set; }
    }
}

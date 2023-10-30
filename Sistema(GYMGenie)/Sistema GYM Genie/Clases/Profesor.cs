using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Profesor : Persona
    {
        public int ProfesorId { get; set; }
        [MaxLength(25)]
        public string? Titulo { get; set; }
        [MaxLength(25)]
        public string? Alias { get; set; }
        public int CBU { get; set; }
        public float Sueldo { get; set; }
    }
}

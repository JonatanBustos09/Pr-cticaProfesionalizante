using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string? Titulo { get; set; }
        public string? Alias { get; set; }
        public int CBU { get; set; }
        public float Sueldo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.Clases
{
    public class Rol
    {
        public int RolId { get; set; }
        [MaxLength(25)]
        public string? TipoRol { get; set; }
    }
}

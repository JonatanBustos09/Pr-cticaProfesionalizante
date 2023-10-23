using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.DBConection
{
    internal class Appdbcontext : DbContext
    {
        //-------------Tablas en Base de Datos------------------

        public DbSet<Clase> Clases { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        //-------------Conección Base de Datos------------------
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-TTV3J71\\SQLEXPRESS; database = DB_GymGenie; trusted_connection = true; Encrypt = False");
        }
    }
}

using Back.LibClases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Back.DB
{
    public class GenieDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Clase> Clases { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=FC;database=GenieDB;trusted_connection=true;Encrypt=False");
        }

    }
}

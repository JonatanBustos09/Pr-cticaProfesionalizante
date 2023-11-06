using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GYM_Genie.DBConection
{
    public class Appdbcontext : DbContext
    {
        //-------------Tablas en Base de Datos------------------
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Inscripcion> Incripciones { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Persona>().UseTpcMappingStrategy().ToTable("Personas"); 
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Profesor>().ToTable("Profesores");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =CHINO\\SQLEXPRESS; database = DB_GymGenie12333; trusted_connection = true; Encrypt = False");
        }
    }
}

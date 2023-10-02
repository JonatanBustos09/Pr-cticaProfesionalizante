using Back.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.LibClases
{
    public class Principal
    {
        public GenieDbContext dbContext;

        public Principal()
        {
            GenieDbContext dbContext = new GenieDbContext();
        }

        public void AltaCliente(Cliente cliente)
        {
            dbContext.Clientes.Add(cliente);
            dbContext.SaveChanges();
        }
        public void AltaProfesor(Profesor profesor)
        {
            dbContext.Profesores.Add(profesor);
            dbContext.SaveChanges();

        }
        public void AltaClase(Clase clase)
        {
            dbContext.Clases.Add(clase);
            dbContext.SaveChanges();

        }
    }
}

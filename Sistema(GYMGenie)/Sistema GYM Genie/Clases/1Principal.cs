using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.DBConection;
using System.Diagnostics.CodeAnalysis;

namespace Sistema_GYM_Genie.Clases
{
    public class Principal
    {
        Appdbcontext context = new Appdbcontext();

        // ALTA de un Profesor

        public void AltaProfesor(string titulo, string alias, int cbu, float sueldo)
        {
            Profesor profesor = new Profesor();
            profesor.Titulo = titulo;
            profesor.Alias = alias;
            profesor.CBU = cbu;
            profesor.Sueldo = sueldo;

            context.Profesores.Add(profesor);
            context.SaveChanges();
        }
        // BAJA de un Profesor
        public void EliminarProfesor(Profesor profesorDelete)
        {
            context.Profesores.Remove(profesorDelete);
            context.SaveChanges();
        }
        //BUSCAR para Modificar un Profesor
        public bool BuscarProfesor(int DNI_Persona)
        {
            var profesorEncontrado = context.Profesores.Find(DNI_Persona);
            if (profesorEncontrado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ALTA de una Persona

        public void AgregarPersona(Persona personaNueva)
        {
            context.Personas.Add(personaNueva);
            context.SaveChanges();
        }



        // BAJA de una Persona

        public void EliminarPersona(int DNI_Persona)
        {
            var personaEncontrada = context.Personas.Find(DNI_Persona);
            if (personaEncontrada != null)
            {
                context.Personas.Remove(personaEncontrada);
                context.SaveChanges();
            }
        }

        // MODIFICACIÓN de una Persona
        public void ModificarPersona(Persona personaModificado)
        {
            var personaEncontrada = context.Personas.Find(personaModificado.DNI_Persona);
            if (personaEncontrada != null)
            {
                personaEncontrada.DNI_Persona = personaModificado.DNI_Persona;
                context.SaveChanges();
            }
        }

        // BUSCAR una Persona a traves del DNI
        // True si Encontre el DNI o False si no encontre el DNI

        public bool BuscarPersona(int DNI_Persona)
        {
            var productoEncontrado = context.Personas.Find(DNI_Persona);
            if (productoEncontrado != null)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
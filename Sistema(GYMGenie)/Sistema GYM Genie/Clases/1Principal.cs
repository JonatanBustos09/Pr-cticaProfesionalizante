using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.DBConection;
using System.Diagnostics.CodeAnalysis;

namespace Sistema_GYM_Genie.Clases
{
    public class Principal
    {
        Appdbcontext context = new Appdbcontext();
        
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
            // F: aca le quise agregar un return diciendo "dni no encontrado, volver a intentar"
            // pero se no me deja cargarlo como string, asique lo voy a tener que codear en el front
            //si avanzamos con lo otro estaria bueno agregarle una verificacion aca en el back.
            
        }

        // BUSCAR una Persona a traves del DNI
        // True si Encontre el DNI o False si no encontre el DNI
        //F: y cual seria la funcion de este buscador de personas?

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

        public bool ValidarLogIn(string usuario, string contraseña)
        {
            
            //aca dejo un posible log ind, deberiamos evaluar que para dar de alta a los profesores con usuario y contraseña.
            {
                // Buscamos si existe una persona con el usuario y la contraseña ingresados
                Profesor admin = context.Profesores.FirstOrDefault(p => p.NombreUsuario == usuario && p.Contrasenia == contraseña);

                // Si la persona existe, devolvemos verdadero
                if (admin != null)
                {
                    return true;
                }
                // Si no existe, devolvemos falso
                else
                {
                    return false;
                }
            }
        }

    }
}
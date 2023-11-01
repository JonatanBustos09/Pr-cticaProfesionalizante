using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.DBConection;
using System.Diagnostics.CodeAnalysis;

namespace Sistema_GYM_Genie.Clases
{
    public class Principal
    {
        Appdbcontext context = new Appdbcontext();

        // ALTA de un Profesor

        public string AgregarProfesor(Profesor ProfeNuevo)
        {
            // Realiza una consulta para verificar si el cliente ya existe en la base de datos.
            var ProfeExistente = context.Profesores.FirstOrDefault(x => x.DNIProfesor == ProfeNuevo.DNIProfesor);
            //FirstOrDefault recuperar el primer elemento de una secuencia que cumple con una condición específica, si no lo encuentra devuelve null

            if (ProfeExistente == null)
            {
                // Si clienteExistente es null, el cliente no existe, entonces lo agregamos.
                context.Profesores.Add(ProfeNuevo);
                context.SaveChanges();
                return ("Cliente agregado exitosamente.");
            }
            else
            {
                return ("El cliente ya existe.");
            }
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

        // ALTA de una Cliente

        public string AgregarCliente(Cliente clienteNuevo)
        {
            // Realiza una consulta para verificar si el cliente ya existe en la base de datos.
            var clienteExistente = context.Clientes.FirstOrDefault(x => x.DNICliente == clienteNuevo.DNICliente);
            //FirstOrDefault recuperar el primer elemento de una secuencia que cumple con una condición específica, si no lo encuentra devuelve null

            if (clienteExistente == null)
            {
                // Si clienteExistente es null, el cliente no existe, entonces lo agregamos.
                context.Clientes.Add(clienteNuevo);
                context.SaveChanges();
                return ("Cliente agregado exitosamente.");
            }
            else
            {
                return ("El cliente ya existe.");
            }
        }
        //Baja Cliente
        public void EliminarCliente(Cliente ClienteDelete)
        {
            context.Clientes.Remove(ClienteDelete);
            context.SaveChanges();
        }

        //BUSCAR para Modificar un Cliente
        public bool BuscarCliente(int DNI_Cliente)
        {
            var ClienteEncontrado = context.Clientes.Find(DNI_Cliente);
            if (ClienteEncontrado != null)
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
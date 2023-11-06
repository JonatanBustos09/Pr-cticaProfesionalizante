using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.DBConection;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sistema_GYM_Genie.Clases
{
    public class Principal
    {
        Appdbcontext context = new Appdbcontext();

        // ALTA de una Cliente

        public void AgregarCliente(Cliente clienteNuevo)
        {
            context.Clientes.Add(clienteNuevo);
            context.SaveChanges();
        }


        //Baja Cliente
        public bool EliminarCliente(int dni)
        {
            Cliente cliente = this.BuscarCliente(dni);

            if (cliente == null)
            {
                return false;
            }
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return true;
        }

        //BUSCAR para Modificar un Cliente
        public Cliente BuscarCliente(int DNI_Cliente)
        {
            return context.Clientes.Find(DNI_Cliente);

        }
        public void ModificarCliente(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        
        {
            return context.Clientes.ToList();

        }
            

        //Agregar Profesor
        public void AgregarProfesor(Profesor ProfesorNuevo)
        {
            context.Profesores.Add(ProfesorNuevo);
            context.SaveChanges();
        }

        //Baja Profesor
        public bool EliminarProfesor(int dni)
        {
            Profesor profesor = this.BuscarProfesor(dni);

            if (profesor == null)
            {
                return false;
            }
            context.Profesores.Remove(profesor);
            context.SaveChanges();
            return true;
        }

        //BUSCAR para Modificar un Profesor
        public Profesor BuscarProfesor(int DNI_Profesor)
        {
            return context.Profesores.Find(DNI_Profesor);
        }

        public List<Profesor> ListarProfesores()
        {
            return context.Profesores.ToList();
        }
        public List<Clase> ListarClases()
        {
            return context.Clases.ToList();
        }

        public void ModificarProfesor(Profesor profesor)
        {
            context.Profesores.Update(profesor);
            context.SaveChanges();
        }

        public void AgregarClase(Clase clasenueva)
        {
            context.Clases.Add(clasenueva);
            context.SaveChanges();
        }
        public void ModificarClase(Clase clase)
        {
            context.Clases.Update(clase);
            context.SaveChanges();
        }

        public void EliminarClase(Clase clase)
        {
            context.Clases.Remove(clase);
            context.SaveChanges();
        }

        public void AgregarInscripcion(Clase claseid, Cliente DNI_Cliente)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Clase = claseid;
            inscripcion.Cliente = DNI_Cliente;

            context.Incripciones.Add(inscripcion);
            context.SaveChanges();

        }

        public string GenerarResumen(int dniCliente)
        {
            StringBuilder retornoRes = new StringBuilder();
            
            List<Inscripcion> inscripciones = context.Incripciones.Include(x=>x.Clase).Where(x => x.ClienteDNI_Persona == dniCliente).ToList();
            foreach (var item in inscripciones)
            {
                retornoRes.AppendLine(item.NombreClase);
            }

            return retornoRes.ToString();
            
        }

        public bool ValidarLogIn(string usuario, string contraseña)
        {

            //aca dejo un posible log ind, deberiamos evaluar que para dar de alta a los profesores con usuario y contraseña.
            {
                // Buscamos si existe una persona con el usuario y la contraseña ingresados
                Profesor profe = context.Profesores.FirstOrDefault(p => p.NombreUsuario == usuario && p.Contrasenia == contraseña);

                // Si la persona existe, devolvemos verdadero
                if (profe != null)
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
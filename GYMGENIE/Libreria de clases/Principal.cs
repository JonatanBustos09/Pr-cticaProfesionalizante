using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases
{
    public class Principal
    {
        List<Cliente> ListaCliente = new List<Cliente>();
        List<Profesor> ListaProfesor = new List<Profesor>();
        List<Clase> ListaClase = new List<Clase>();
        List<Admin> ListaAdmin = new List<Admin>();

        public void Altacliente(int DNI, string nombre, string apellido, DateTime FechaNac) //es void porque no retorna ningun valor
        {
            Cliente clientenuevo = new Cliente();
            clientenuevo.idClient = clientenuevo.idClient + 1;
            clientenuevo.DNI = DNI;
            clientenuevo.Nombre = nombre;
            clientenuevo.Apellido = apellido;
            clientenuevo.FechaNacimiento = FechaNac;
            ListaCliente.Add(clientenuevo);
        }
        public void AltaProfesor(int DNI, string nombre, string apellido, DateTime FechaNac, string Mail, string Direccion)
        {
            Profesor profesornuevo = new Profesor();
            profesornuevo.idprof = profesornuevo.idprof + 1;
            profesornuevo.DNI = DNI;
            profesornuevo.Nombre = nombre;
            profesornuevo.Apellido = apellido;
            profesornuevo.FechaNacimiento = FechaNac;
            profesornuevo.Direccion = Direccion;
            profesornuevo.Mail = Mail;
            ListaProfesor.Add(profesornuevo);

        }
        public void AltaClase(string Nombreclase, DateTime Horario, int Nivelclase)
        {
            Clase clasenueva = new Clase();
            clasenueva.idClase = clasenueva.idClase + 1;
            clasenueva.Nombreclase = Nombreclase;
            clasenueva.Horario = Horario;
            //clasenueva.Nivelclase.Nivel1 = Nivelclase;
            ListaClase.Add(clasenueva);

        }
        public void AltaAdmin(int DNI, string nombre, string apellido, DateTime FechaNac, string Mail, string Direccion, int Telefono)
        {
            Admin AdminNuevo = new Admin();
            AdminNuevo.idAdmin = AdminNuevo.idAdmin + 1;
            AdminNuevo.DNI = DNI;
            AdminNuevo.Nombre = nombre;
            AdminNuevo.Apellido = apellido;
            AdminNuevo.Mail = Mail;
            AdminNuevo.Telefono = Telefono;
            AdminNuevo.FechaNacimiento = FechaNac;
            AdminNuevo.Direccion = Direccion;
            ListaAdmin.Add(AdminNuevo);
        }

        public void modificarCliente(int idCliente, Cliente clientenuevo)
        {
            Cliente clienteModificado = new Cliente();
            var clienteEncontrado = ListaCliente.Find(x => x.idClient == idCliente);
            if (clienteEncontrado != null)
            {
                clienteModificado.idClient = clienteEncontrado.idClient;
                clienteModificado.DNI = clienteModificado.DNI;
                clienteModificado.Nombre = clienteModificado.Nombre;
                clienteModificado.Apellido = clienteModificado.Apellido;
                clienteModificado.FechaNacimiento = clienteModificado.FechaNacimiento;
                ListaCliente.Add(clientenuevo);
                ListaCliente.Remove(clienteEncontrado);

            }

        }
        public void EliminarCliente(int idCliente)
        {

            var clienteEncontrado = ListaCliente.Find(x => x.idClient == idCliente);
            ListaCliente.Remove(clienteEncontrado);
        }

        public void modificarProfesor(int idProf, Profesor profesornuevo)
        {
            Profesor profesorModificado = new Profesor();
            var ProfesorEncontrado = ListaProfesor.Find(x => x.idprof == idProf);
            if (ProfesorEncontrado != null)
            {
                profesorModificado.idprof = ProfesorEncontrado.idprof;
                profesorModificado.DNI = profesorModificado.DNI;
                profesorModificado.Nombre = profesorModificado.Nombre;
                profesorModificado.Apellido = profesorModificado.Apellido;
                profesorModificado.FechaNacimiento = profesorModificado.FechaNacimiento;
                profesorModificado.Direccion = profesorModificado.Direccion;
                profesorModificado.Mail = profesorModificado.Mail;
                ListaProfesor.Add(profesornuevo);
                ListaProfesor.Remove(ProfesorEncontrado);

            }
        }
        public void EliminarProfesor(int idprof)
        {

            var ProfesorEncontrado = ListaProfesor.Find(x => x.idprof == idprof);
            ListaProfesor.Remove(ProfesorEncontrado);
        }
        public void modificarAdmin(int idAdmin, Admin Adminnuevo)
        {
            Admin AdminModificado = new Admin();
            var AdminEncontrado = ListaAdmin.Find(x => x.idAdmin == idAdmin);
            if (AdminEncontrado != null)
            {
                AdminModificado.idAdmin = AdminEncontrado.idAdmin;
                AdminModificado.DNI = AdminModificado.DNI;
                AdminModificado.Nombre = AdminModificado.Nombre;
                AdminModificado.Apellido = AdminModificado.Apellido;
                AdminModificado.FechaNacimiento = AdminModificado.FechaNacimiento;
                AdminModificado.Direccion = AdminModificado.Direccion;
                AdminModificado.Mail = AdminModificado.Mail;
                ListaAdmin.Add(Adminnuevo);
                ListaAdmin.Remove(AdminEncontrado);

            }
        }
        public void EliminarAdmin(int idAdmin)
        {

            var AdminEncontrado = ListaAdmin.Find(x => x.idAdmin == idAdmin);
            ListaAdmin.Remove(AdminEncontrado);
        }
        public void modificarClase(int idClase, Clase Clasenuevo)
        {
            Clase AdminModificado = new Clase();
            var ClaseEncontrado = ListaClase.Find(x => x.idClase == idClase);
            if (ClaseEncontrado != null)
            {
                AdminModificado.idClase = ClaseEncontrado.idClase;
                AdminModificado.Nombreclase = AdminModificado.Nombreclase;
                AdminModificado.Horario = AdminModificado.Horario;
                ListaClase.Add(Clasenuevo);
                ListaClase.Remove(ClaseEncontrado);

            }
        }
        public void EliminarClase(int idClase)
        {

            var ClaseEncontrado = ListaClase.Find(x => x.idClase == idClase);
            ListaClase.Remove(ClaseEncontrado);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryclasesproyecto
{
    public class Principal
    {
        List<Cliente> ListaCliente = new List<Cliente>();
        List<Profesor> ListaProfesor = new List<Profesor>();
        List<Clase> ListaClase = new List<Clase>();
        List<Administrador> ListaAdmin = new List<Administrador>();

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
            ListaClase.Add(clasenueva);

        }
        public void AltaAdmin(int DNI, string nombre, string apellido, DateTime FechaNac, string Mail, string Direccion, string Telefono)
        {
            Administrador AdminNuevo = new Administrador();
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
    }
}

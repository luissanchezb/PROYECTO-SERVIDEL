using System;
using System.Collections.Generic;
using System.Text;

namespace ServiDel
{
    public class Cliente : Usuario
    {

        //Propiedades únicas del cliente
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private string NombredeUsuario { get; set; }




        //Método para actualizacion de perrfil
        public void Actualizarperfil()
        {
            Actualizarperfil();

        }
        
        

        //Método abstracto realizado para el Inicio de sesión
        public override  void Iniciodesesion()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
                Console.WriteLine("\tSoftware para el servicio de Delibery");
                Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("<<<<<<<<<<<<< Inicio Sesion Cliente >>>>>>>>>>>>>>");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre de usuario cliente: ");
            NombredeUsuario= Console.ReadLine();
            Console.WriteLine("Escriba su  contraseña: ");
            contrasena = Console.ReadLine();
        }


        //Método sobreescrito para el registro de cliente
        public override void registrousuario()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
            Console.WriteLine("\tSoftware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("<<<<<<<<<<<<<<<< Registro Cliente >>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            Console.WriteLine("Escriba su Nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su Apellido: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Escriba su Nombre de Usuario: ");
            NombredeUsuario = Console.ReadLine();
            Console.WriteLine("Escriba su Email: ");
            email = Console.ReadLine();
            Console.WriteLine("Escriba su  contraseña: ");
            contrasena = Console.ReadLine();

            do
            {
                Console.WriteLine("Confirme su contraseña: ");
                confirmarcontrasena = Console.ReadLine();
                if (contrasena != confirmarcontrasena)
                {
                    Console.WriteLine("Contraseñas no coinciden");
                }

            }
            while (contrasena != confirmarcontrasena);

            Console.WriteLine("El cliente ha sido registrado");


            
        }

    }


}

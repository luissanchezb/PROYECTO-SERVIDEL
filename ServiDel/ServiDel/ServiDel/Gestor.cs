using System;
using System.Collections.Generic;
using System.Text;

namespace ServiDel
{
    public class Gestor:Usuario
    {
        //Propiedades únicas del gestor
        private string NombredeDelivery { get; set; }
        private string NombredeGestor { get; set; }
        private string EmailRespaldo { get; set; }
        private int NumerodeTarjeta { get; set; }

        private string fv { get; set; }

        //Método para actualizacion de perfil
        public void Actualizarperfil()
        {
            Actualizarperfil();

        }
       

        //Método para Promocionar
        public void Promocionar()
        {
            Promocionar();

        }

        //Método para Detallar
        public void Detallar()
        {
            Detallar();

        }


        //Método abstracto realizado para el Inicio de sesión
        public override void Iniciodesesion()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
            Console.WriteLine("\tSoftware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("<<<<<<<<<<<<< Inicio Sesion Gestor  >>>>>>>>>>>>>>");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre de usuario gestor: ");
            NombredeGestor = Console.ReadLine();
            Console.WriteLine("Escriba su  contraseña: ");
            contrasena = Console.ReadLine();

            Console.WriteLine("Ha iniciado sesion como gestor");


        }





        //Método sobreescrito para el registro de gestor




        List<Gestor> lista_gestores = new List<Gestor>();
        public override void registrousuario()
        {
            Gestor n_gestores = new Gestor();
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
            Console.WriteLine("\tSoftware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("<<<<<<<<<<<<<<< Suscripcion Gestor >>>>>>>>>>>>>>>");
            Console.WriteLine("");
            Console.WriteLine("Escriba el Nombre de su Delivery: ");
            n_gestores.NombredeDelivery = Console.ReadLine();
            Console.WriteLine("Escriba su Nombre de gestor: ");
            n_gestores.NombredeGestor = Console.ReadLine();
            Console.WriteLine("Escriba su email: ");
            n_gestores.email = Console.ReadLine();
            Console.WriteLine("Escriba su nombre de email de respaldo: ");
            n_gestores.EmailRespaldo = Console.ReadLine();
            Console.WriteLine("Escriba su contraseña: ");
            n_gestores.contrasena = Console.ReadLine();
            lista_gestores.Add(n_gestores);
            do
            {
                Console.WriteLine("Confirme su contraseña: ");
                n_gestores.confirmarcontrasena = Console.ReadLine();
                if (n_gestores.contrasena != n_gestores.confirmarcontrasena)
                {
                    Console.WriteLine("Contraseñas no coinciden");
                }

            }
            while (n_gestores.contrasena != n_gestores.confirmarcontrasena);

            Console.WriteLine("El gestor ha sido registrado");
            
        }


        List<Gestor> lista_favoritos = new List<Gestor>();
        public void fav()
        {
            Gestor n_favoritos = new Gestor();
            bool buscar=false;
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
            Console.WriteLine("\tSotfware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("Favoritos: ");
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            foreach (Gestor item in lista_favoritos)
            {
                
                Console.WriteLine("Nombre de delibery: " + item.fv);
                Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            }
            Console.WriteLine("Ingrese nombre de Delibery para agregar a favorito: ");
            string agfav = Console.ReadLine();
            foreach (Gestor p in lista_gestores)
            {
                if (p.NombredeDelivery== agfav)
                {
                    n_favoritos.fv = p.NombredeDelivery;
                    Console.WriteLine(p.NombredeDelivery+" se ah agregado a favoritos.");
                    lista_favoritos.Add(n_favoritos);
                    buscar = true;

                }
            }
            if (buscar==false)
            {
                Console.WriteLine(agfav + " no se ah encontrado en la lista de gestores.");
            }

            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");

        }


        public void consultargestores()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tSERVIDEL");
            Console.WriteLine("\tSoftware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("Deliberys disponibles: \n");
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");

            foreach (Gestor item in lista_gestores)
            {
                Console.WriteLine("Nombre Delibery: " + item.NombredeDelivery);
                Console.WriteLine("Nombre de su gestor: " + item.NombredeGestor);
                Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            }
            
        }
    }
}

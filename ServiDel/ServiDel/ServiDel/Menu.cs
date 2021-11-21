using System;
using System.Collections.Generic;
using System.Text;

namespace ServiDel
{
    class Menu
    {
        private Gestor lista_Gestores=new Gestor();
        private int op;
        private int op1;
        private int op2;
        private int inicio;

        public int getinicio()
        {
            return inicio;
        }
        public void setinicio(int inicio)
        {
            this.inicio = inicio;
        }

        Cliente cliente1 = new Cliente();
        Gestor gestor1 = new Gestor();

        public void Mostrar()
        {
            do { 
            Console.Clear();
            Console.WriteLine("\t\tBIENVENIDO A SERVIDEL");
            Console.WriteLine("\tSoftware para el servicio de Delibery");
            Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("1. Iniciar sesion como Cliente");
            Console.WriteLine("2. Iniciar sesion como Gestor");

            Console.WriteLine("3. Registro Como Cliente");
            Console.WriteLine("4. Registro Como Gestor");
            Console.WriteLine("5. Salir");
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("Opcion: ");

            op = int.Parse(Console.ReadLine());

            if (op < 1 || op > 5)
            {
                Console.WriteLine("La opcion ingresada no es valida");
                Console.WriteLine("Preciona una tecla para continuar...");
                Console.ReadKey();
            }

            switch (op)
            {
                case 1:
                        { 
                            cliente1.Iniciodesesion();
                            break;
                        }

                    case 2:

                    gestor1.Iniciodesesion();

                    break;

                case 3:

                    cliente1.registrousuario();
                    
                    break;

                case 4:

                    gestor1.registrousuario();

                    break;
                case 5:
                        Environment.Exit(0);
                        break;
            }
            this.inicio = op;
            if (op == 1 || op == 3)
            {

                mostrarcliente();

            }
            else
            {
                if (op == 2 || op == 4)
                {


                    mostrargestor();


                }
            }
            } while (op != 4);
        }

        public void mostrarcliente()
        {
            do {
            Console.Clear();
                Console.WriteLine("\t\t\tSERVIDEL");
                Console.WriteLine("\tSoftware para el servicio de Delibery");
                Console.WriteLine("\n\t\t\tFecha: " + DateTime.Now);
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<< Cliente >>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("1. Favoritos");
            Console.WriteLine("2. Notificaciones");
            Console.WriteLine("3. Ajustes");
            Console.WriteLine("4. Busqueda");
            Console.WriteLine("5. Seleccion de servicios");
            Console.WriteLine("6. Promociones");
            Console.WriteLine("7. Cerrar sesion");
            Console.WriteLine("►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►");
            Console.WriteLine("Opcion: ");
            op1 = int.Parse(Console.ReadLine());
            if (op1 < 1 || op1 > 8)
            {
                Console.WriteLine("La opcion ingresada no es valida");
                Console.WriteLine("Preciona una tecla para continuar...");
                Console.ReadKey();
            }

            switch (op1)
            {
                case 1:
                        { 
                            gestor1.fav();
                            Console.WriteLine("Preciona una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }

                case 2:
                        {

                            break;
                        }

                    case 3:
                        {

                            break;
                        }

                    case 4:
                        {

                            break;
                        }

                case 5:
                        {
                            gestor1.consultargestores();
                            Console.WriteLine("Preciona una tecla para continuar...");
                            Console.ReadKey();
                            break;
                        }  
                case 6:
                        {

                            break;
                        }
                    case 7:
                        { 
                            Console.Clear();
                            Mostrar();
                            break;
                        }
            }

            }while(op != 8);
            Console.WriteLine("Fin.");
        }
        public void mostrargestor()
        {

            Console.WriteLine("es gestor " + op);
            gestor1.consultargestores();
            Mostrar();
        }

    }
}

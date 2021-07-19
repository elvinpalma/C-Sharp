//Elvin Noé Palma Hernández 20192001535

//Librería a utilizar
using System;

namespace _10_Orden
{
    class Program
    {
        //Inicia el programa principal, donde se mostrará el menú principal del sistema de ordenes
        static void Main(string[] args)
        {
            //Estancia necesaria
            DatosdePrueba datos = new DatosdePrueba();

            //Variable a utilizar
            string opcion = "";

            //Inicia ciclo while
            while (true)
            {
                //Comando para limpiar la pantalla
                Console.Clear();

                //Mensaje del sistema de ordenes
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");

                //Son las diferentes opciones que se muestran en el menú principal
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                
                //Esta opción es para salir del menú  principal
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");

                //Mensaje solicitando que escoja una opcion del menú principal
                Console.Write("Ingrese una opcion del menu: ");
                opcion = Console.ReadLine();

                //Según la opción seleccionada se  trabajará con una de estas opciones
                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;

                    case "2":
                        datos.CrearOrden();
                        break;    

                    case "3":
                        datos.ListarClientes();
                        break;

                    case "4":
                        datos.ListarVendedores();
                        break;

                    case "5":
                        datos.ListarOrdenes();
                        break;

                    default:
                        break;
                }

                //Si la opción seleccionada  es 0 entonces el programa sale del menú principal
                if (opcion == "0")
                {
                    Console.Clear();
                    break;

                }
            }
        }
    }
}

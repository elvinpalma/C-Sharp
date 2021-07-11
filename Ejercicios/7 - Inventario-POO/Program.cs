//Elvin Noé Palma Hernández 20192001535

//Librería a utilizar
using System;

namespace inventario
{
    class Program
    {

        //Inicia el programa principal, donde se mostrará el menú principal del sistema de inventario
        static void Main(string[] args)
        {
            //Variables a utilizar
            string opcion = "";
            
            //Estancia necesaria 
            Inventario inventario = new Inventario();

            //Inicia ciclo while
            while (true)
            {
                //Comando para limpiar la pantalla
                Console.Clear();
                
                //Mensaje del sistema de inventario
                Console.WriteLine("Sistema de Invetario");
                Console.WriteLine("********************");
                Console.WriteLine("");

                //Son las diferentes opciones que se muestran en el menú principal
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Invetario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste Negativo de Inventario");
                Console.WriteLine("5 - Ajuste Positivo de Inventario");
                
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
                        inventario.listarProductos();                 
                    break;

                    case "2":
                        inventario.ingresoDeInventario();
                    break;

                    case "3":
                        inventario.salidaDeProductos();
                    break;

                    case "4":
                        inventario.ajusteNegativoDeInventario();
                    break;

                    case "5":
                        inventario.ajustePositivoDeInventario();
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

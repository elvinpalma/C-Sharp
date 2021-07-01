//Elvin Noé Palma Hernández 20192001535

using System;

namespace Inventario
{
    class Program
    {
        //Lista de productos que estan en el inventario
        static string [,] Productos = new string[5,3]
        {
            {"001", "iPhone X", "0"},
            {"002", "Laptop Dell", "5"},
            {"003", "Monitor Samsung", "2"},
            {"004", "Mouse", "100"},
            {"005", "HeadSet", "25"},
        };

        //Función donde se muestra la lista de productos que están en el inventario
        static void ListarProductos()
        {
            //Comando para limpiar la pantalla
            Console.Clear();
            Console.WriteLine("");

            //Mensaje mostrando los productos del inventario
            Console.WriteLine("Lista de Productos");
            Console.WriteLine("******************");
            Console.WriteLine("");
            Console.WriteLine("Codigo, Descricion y Existencia");

            //Ciclo for para mostrar el inventario
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Productos[i, 0] + " | " + Productos[i, 1] + " | " + Productos[i, 2]);
            }

            //Comando para pausar el programa
            Console.ReadLine();
        }

        //Función donde se hacen los calculos correspondientes con respecto a la cantidad de productos
        static void MovimientoInventario(string codigo, int cantidad, string tipoMovimiento)
        {
            //Ciclo donde se están haciendo los diferentes movimientos en el inventario
            for (int i = 0; i < 5; i++)
            {
                if (Productos[i, 0] == codigo)
                {
                    if (tipoMovimiento == "+")
                    {
                        Productos[i, 2] = (Int32.Parse(Productos[i, 2]) + cantidad).ToString();
                    } 
                    else
                    {
                        Productos[i, 2] = (Int32.Parse(Productos[i, 2]) - cantidad).ToString();
                    }
                    
                }
            }
            
        }

        //Función donde se le aumenta los ingresos a la cantidad de productos al inventario
        static void IngresoDeInventario()
        {
            //Variables a utilizar
            string codigo = " ";
            string cantidad = " ";

            //Comando para limpiar la pantalla
            Console.Clear();
            Console.WriteLine("");

            //Mensaje para ingresar productos del inventario
            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            
            //Mensaje solicitando el código del producto
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            //Mensaje solicitando  la canitdad de producto a ingresar
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            //Esta función hará que los movimientos del inventario sean positivo
            MovimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        //Función donde se le resta todas las salidas a la cantidad de productos del inventario
        static void SalidaDeProductos()
        {
            //Variables a utilizar
            string codigo = " ";
            string cantidad = " ";

            //Comando para limpiar la pantalla
            Console.Clear();
            Console.WriteLine("");

            //Mensaje para indicar las salidas de los productos del inventario
            Console.WriteLine("Salida de Productos del Inventario");
            Console.WriteLine("**********************************");
            
            //Mensaje solicitando el código del producto
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            //Mensaje solicitando  la canitdad de producto a ingresar
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            //Esta función hará que los movimientos del inventario sean negativo
            MovimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        //Función donde se hacen los ajustes negativos, lo cual es restar la cantidad de productos del inventario
        static void AjusteNegativoDeInventario()
        {
            //Variables a utilizar
            string codigo = " ";
            string cantidad = " ";

            //Comando para limpiar la pantalla
            Console.Clear();
            Console.WriteLine("");

            //Mensaje para indicar los ajustes negativos del inventario
            Console.WriteLine("Ajuste Negativo del Inventario");
            Console.WriteLine("******************************");
            
            //Mensaje solicitando el código del producto
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            //Mensaje solicitando  la canitdad de producto a ingresar
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            //Esta función hará que los movimientos del inventario sean negativo
            MovimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        //Función donde se hacen los ajustes positivos, lo cual  es sumar la cantidad de productos del inventario
        static void AjustePositivoDeInventario()
        {
            //Variables a utilizar
            string codigo = " ";
            string cantidad = " ";

            //Comando para limpiar la pantalla
            Console.Clear();
            Console.WriteLine("");

            //Mensaje para indicar los ajustes positivos del inventario
            Console.WriteLine("Ajuste Positivo del Inventario");
            Console.WriteLine("******************************");
            
            //Mensaje solicitando el código del producto
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.WriteLine("");

            //Mensaje solicitando  la canitdad de producto a ingresar
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            Console.WriteLine("");

            //Esta función hará que los movimientos del inventario sean positivo
            MovimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        //Inicia el programa principal, donde se mostrará el menú principal del sistema de inventario
        static void Main(string[] args)
        {
            //Variable a utilizar
            string opcion = "";

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
                        ListarProductos();                 
                    break;

                    case "2":
                        IngresoDeInventario();
                    break;

                    case "3":
                        SalidaDeProductos();
                    break;

                    case "4":
                        AjusteNegativoDeInventario();
                    break;

                    case "5":
                        AjustePositivoDeInventario();
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

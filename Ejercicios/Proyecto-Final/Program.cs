//Elvin Noé Palma Hernández 20192001535

using System;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estancia necesaria
            Notas notas = new Notas();

            //Variable a utilizar
            string opcion = "";

            //Inicia ciclo while
            while (true)
            {
                //Comando para limpiar la pantalla
                Console.Clear();

                Console.WriteLine("Escuela Éxitos de Anach #2");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                //Mensaje del sistema de notas
                Console.WriteLine("Sistema de Notas");
                Console.WriteLine("================");
                Console.WriteLine("");

                //Son las diferentes opciones que se muestran en el menú principal
                Console.WriteLine("1 - Lista de Estudiantes");
                Console.WriteLine("2 - Lista de Asinaturas");
                Console.WriteLine("3 - Ingreso de Acumulados");
                Console.WriteLine("4 - Notas Finales");
                
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
                        notas.listarEstudiantes();
                        
                        break;

                    case "2":
                        notas.listarAsignaturas();
                        break;    

                    case "3":
                        notas.ingresarAcumulados();
                        break;

                    case "4":
                        notas.notasFinales();
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
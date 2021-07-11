using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "Perez");
            Alumno b = new Alumno(2, "Maria", "Martinez");

            a.inactivarAlumno();
            
            Console.WriteLine(a.NombreCompleto());
            Console.WriteLine(b.NombreCompleto());

            a.activarAlumno();

            Console.WriteLine(" ");
            
            Console.WriteLine(a.NombreCompleto());
            Console.WriteLine(b.NombreCompleto());
        }
    }
}

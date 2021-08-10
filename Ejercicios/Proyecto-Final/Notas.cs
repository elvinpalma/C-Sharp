//Elvin Noé Palma Hernández 20192001535

//Librerías a utilizar
using System;
using System.Collections.Generic;

//Se inicia la clase Notas
public class Notas
{
    //Propiedades de la clase
    public List<Estudiante> ListadeEstudiantes { get; set; }
    public List<Asignaturas> ListadeAsignaturas { get; set; }

    //Constructor de la clase para inicializar las propiedades
    public Notas() //Se utiliza polimorfismo
    {
        ListadeEstudiantes = new List<Estudiante>();
        cargarEstudiantes();

        ListadeAsignaturas = new List<Asignaturas>();
        cargarAsinaturas();

    }

    //Función de la lista de estudiantes
    private void cargarEstudiantes() //Se utiliza encapsulamiento
    {
        Estudiante e1 = new Estudiante(101, "Segio", "Sandoval");
        ListadeEstudiantes.Add(e1);
        
        Estudiante e2 = new Estudiante(102, "Adolfo", "Reyes");
        ListadeEstudiantes.Add(e2);

        Estudiante e3 = new Estudiante(103, "Javier", "Martínez");
        ListadeEstudiantes.Add(e3);

        Estudiante e4 = new Estudiante(104, "Tulio", "Sanchéz");
        ListadeEstudiantes.Add(e4);
    }

    //Función de la lista de asignaturas
    private void cargarAsinaturas()//Se utiliza encapsulamiento
    {
        Asignaturas a1 = new Asignaturas(201, "Matemáticas");
        ListadeAsignaturas.Add(a1);

        Asignaturas a2 = new Asignaturas(202, "Español");
        ListadeAsignaturas.Add(a2);

        Asignaturas a3 = new Asignaturas(203, "Ciencias Sociales");
        ListadeAsignaturas.Add(a3);

        Asignaturas a4 = new Asignaturas(204, "Ciencias Naturales");
        ListadeAsignaturas.Add(a4);

    }

    //Función para mostrar la lista de estudiantes
    public void listarEstudiantes() // Se utiliza abstracción
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes");
        Console.WriteLine("====================");
        Console.WriteLine("");

        foreach (var estudiante in ListadeEstudiantes)
        {
            Console.WriteLine(estudiante.CodigoEstudiante + " | " + estudiante.Nombre + " | " + estudiante.Apellido);
        }

        Console.ReadLine();
    }

    //Función para mostrar la lista de asignaturas
    public void listarAsignaturas() // Se utiliza abstracción
    {
        Console.Clear();

        Console.Clear();
        Console.WriteLine("Lista de Asignaturas");
        Console.WriteLine("====================");
        Console.WriteLine("");

        foreach (var asignatura in ListadeAsignaturas)
        {
            Console.WriteLine(asignatura.CodigoAsinagtura + " | " + asignatura.NombreAsignatura);
        }

        Console.ReadLine();
    }

    //Función para ingresar las notas acumuladas
    public void ingresarAcumulados() // Se utiliza abstracción
    {
        Console.Clear();

        Console.WriteLine("Notas Acumuladas");
        Console.WriteLine("================");
        Console.WriteLine("");

        //Se ingresa el código del estudiante
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        string codigoEstudiante = Console.ReadLine();

        Estudiante estudiante = ListadeEstudiantes.Find(e => e.CodigoEstudiante.ToString() == codigoEstudiante);

        //En caso de no encontrarlo, se ejecuta esta condición
        if (estudiante == null)
        {
            Console.WriteLine("Estudiante no encontrado");
            Console.ReadLine();
            return;
        }
        else
            {
                Console.WriteLine(""); 
                Console.WriteLine("Estudiante: " + estudiante.Nombre + " " + estudiante.Apellido);
                Console.WriteLine("");   
            }
        
        //Se ingresan las notas de los 4 parciles en las 4 asignaturas      
        foreach (var asignatura in ListadeAsignaturas)
        {
            Console.WriteLine("Asignatura: " + asignatura.NombreAsignatura);
            Console.WriteLine("");
            Console.WriteLine("Ingresar las 4 notas parciales");
            Console.WriteLine("");

            Console.Write("Nota 1: ");
            asignatura.Nota1 = Int32.Parse(Console.ReadLine());

            if (asignatura.Nota1 >= 100 || asignatura.Nota1 <= 0)
            {
                Console.WriteLine("Tiene que ser un número entre 1 a 100");
                asignatura.Nota1 = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Nota 2: ");
            asignatura.Nota2 = Int32.Parse(Console.ReadLine());

            if (asignatura.Nota2 >= 100 || asignatura.Nota2 <= 0)
            {
                Console.WriteLine("Tiene que ser un número entre 1 a 100");
                asignatura.Nota2 = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Nota 3: ");
            asignatura.Nota3 = Int32.Parse(Console.ReadLine());

            if (asignatura.Nota3 >= 100 || asignatura.Nota3 <= 0)
            {
                Console.WriteLine("Tiene que ser un número entre 1 a 100");
                asignatura.Nota3 = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Nota 4: ");
            asignatura.Nota4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            if (asignatura.Nota4 >= 100 || asignatura.Nota4 <= 0)
            {
                Console.WriteLine("Tiene que ser un número entre 0 a 100");
                asignatura.Nota4 = Int32.Parse(Console.ReadLine());
            }

            //Operación matemática para evaluar el promedio de cada materia
            asignatura.NotaPromedio = (asignatura.Nota1 + asignatura.Nota2 + asignatura.Nota3 + asignatura.Nota4) / 4;
            
        }

        
        //Se muestarn las calificaciones
        foreach (var nota in ListadeAsignaturas)
        {
            
            Console.WriteLine("Su Promedio es de: " + nota.NotaPromedio + " en " + nota.NombreAsignatura);
        }

        Console.ReadLine();
    }

    //Función para mostrar las notas finales
    public void notasFinales() // Se utiliza abstracción
    {
        Console.Clear();
        Console.WriteLine("Calificación final");
        Console.WriteLine("==================");
        Console.WriteLine("");

        //Se ingresa el código del estudiante
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        string codigoEstudiante = Console.ReadLine();

        Estudiante estudiante = ListadeEstudiantes.Find(e => e.CodigoEstudiante.ToString() == codigoEstudiante);

        //En caso de no encontrarlo, se ejecuta esta condición
        if (estudiante == null)
        {
            Console.WriteLine("Estudiante no encontrado");
            Console.ReadLine();
            return;
        }
        else
            {
                Console.WriteLine(""); 
                Console.WriteLine("Estudiante: " + estudiante.Nombre + " " + estudiante.Apellido);
                Console.WriteLine("");   
            }

        //Se muestra las calificaciones
        foreach (var nota in ListadeAsignaturas)
        {
            
            Console.WriteLine("Su Promedio es de: " + nota.NotaPromedio + " en " + nota.NombreAsignatura);  
            
        }

        Console.ReadLine();
    }
}
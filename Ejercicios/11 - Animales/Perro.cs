//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Perro:Mamiferos //Se tiene una herencia de la clase Mamiferos
{
    //Propiedades
    public bool Domestico { get; set; } 
    public string Raza { get; set; }

    //Constructor estableciendo que el valor lógico es verdadero
    public Perro() //Se utiliza el polimorfismo
    {
            Domestico = true;
    }

    //Constructor inicalizando las propiedades
    public Perro(bool domestico, string raza, string nombre, int patas) //Se utiliza el polimorfismo
    {
            Domestico = domestico;
            Raza = raza;
            Nombre = nombre;
            Patas = patas;
    }

    //Funcion ladrar
    public void ladrar()//Se utiliza la abstraccion
    {
        Console.WriteLine("Guau guau guau");
    }

    //Funcion del tamaño del  perro
    public void tamanoPerro() //Se utiliza la abstraccion
    {
        descripciondelTamanoPerro();
    }

    //Funcion privada del tamaño  del perro
    private void descripciondelTamanoPerro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un perro grande");
    }

    //Funcion de la vida del perro
    public void vidaDomesticaPerro() //Se utiliza la abstraccion
    {
        caracteristicasPerro();
        habilidadesdelPerro();
    }

    //Funcion privada de las caracteristicas del perro
    private void caracteristicasPerro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es domestico");
        Console.WriteLine("Vive con una familia");
        Console.WriteLine("Cuida la casa");
        Console.WriteLine("Es cariñoso");
        Console.WriteLine("Es fiel");
    }

    //Funcion privada de las habilidades del perro
    private void habilidadesdelPerro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Perro");
        Console.WriteLine("=====================");
        Console.WriteLine("Tiene un olfato muy desarrollado");
        Console.WriteLine("Es sobreprotector");
    }
}
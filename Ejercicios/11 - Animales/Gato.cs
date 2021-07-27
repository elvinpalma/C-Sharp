//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Gato:Mamiferos //Se tiene una herencia de la clase Mamiferos
{
    //Propiedades
    public bool Domestico { get; set; } 
    public string Raza { get; set; }
    public string Pelaje { get; set; }

    //Constructor estableciendo que el valor lógico es verdadero
    public Gato() //Se utiliza el polimorfismo
    {
        Domestico = true;
    }

    //Constructor inicalizando las propiedades
    public Gato(bool domestico, string raza, string pelaje, string nombre, int patas) //Se utiliza el polimorfismo
    {
        Domestico = domestico;
        Raza = raza;
        Pelaje = pelaje;
        Nombre = Nombre;
        Patas = patas;
    }
    
    //Funcion maullar
    public void maullar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Miau miau miau");
    } 

    //Funcion tamaño del gato
    public void tamanoGato() //Se utiliza la abstraccion
    {
        descripciondelTamanoGato();
    }

    //Funcion privada del tamaño del gato
    private void descripciondelTamanoGato() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un gato pequeño");
    } 

    //Funcion de la vida del gato
    public void vidaDomesticaGato() //Se utiliza la abstraccion
    {
        caracteristicasGato();
        habilidadesdelGato();
    }

    //Funcion privada de las caracteristicas del gato
    private void caracteristicasGato() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es domestico");
        Console.WriteLine("Vive con una familia");
        Console.WriteLine("Es cariñoso");
    }

    //Funcion privada de las habilidades del gato
    private void habilidadesdelGato() //Se utiliza el encapsulamiento
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Gato");
        Console.WriteLine("====================");
        Console.WriteLine("Tiene vision nocturna");
        Console.WriteLine("Puede cazar ratones");
        Console.WriteLine("Puede trepar");
    }
}
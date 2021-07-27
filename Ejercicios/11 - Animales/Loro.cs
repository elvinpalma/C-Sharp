//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Loro:Aves //Se tiene una herencia de la clase Aves
{
    //Propiedades
    public bool Domestico { get; set; }
    public int Patas { get; set; }
    public string Raza { get; set; }
    public int Alas { get; set; }

    //Constructor estableciendo que el valor lógico es verdadero
    public Loro() //Se utiliza el polimorfismo
    {
        Domestico = true;
    }

    //Constructor inicalizando las propiedades
    public Loro(bool domestico, string nombre, int patas, string colorPlumaje, string raza, int alas) //Se utiliza el polimorfismo
    {
        Domestico = domestico;
        Nombre = nombre;
        Patas = patas;
        ColorPlumaje = colorPlumaje;
        Raza = raza;
        Alas = alas;
    }

    //Funcion hablar 
    public void hablar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Hablando");
    } 

    //Funcion del tamaño del loro
    public void tamanoLoro() //Se utiliza la abstraccion
    {
        descripciondelTamanoLoro();
    }

    //Funcion privada del loro
    private void descripciondelTamanoLoro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un ave pequeña");
    }

    //Funcion de la vida del loro
    public void vidaDomesticadelLoro() //Se utiliza la abstraccion
    {
        caracteristicasLoro();
        habilidadesdelLoro();
    }

    //Funcion privada de las caracteristicas del loro
    private void caracteristicasLoro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es Domestico");
        Console.WriteLine("Vive con una familia");
        Console.WriteLine("Come semillas");
        Console.WriteLine("Avisa si hay visitas");
    }

    //Funcion privada de las habilidades del loro
    private void habilidadesdelLoro() //Se utiliza el encapsulamiento
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Loro");
        Console.WriteLine("======================");
        Console.WriteLine("Es un animal que tiene cuerdas vocales");
    }
}
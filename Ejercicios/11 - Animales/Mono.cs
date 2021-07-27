//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Mono:Mamiferos //Se tiene una herencia de la clase Mamiferos
{
    //Propiedades
    public bool Domestico { get; set; }
    public int Manos { get; set; }
    public string Raza { get; set; }

    //Constructor estableciendo que el valor lógico es verdadero
    public Mono() //Se utiliza el polimorfismo
    {
        Domestico = true;
    }

    //Constructor inicalizando las propiedades
    public Mono(bool domestico, int manos, string nombre, int patas, string raza) //Se utiliza el polimorfismo
    {
        Domestico = domestico;
        Manos = manos;
        Raza = raza;
        Nombre = nombre;
        Patas = patas;
    }

    //Funcion aullar
    public void aullar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Ua ua ua");
    }

    //Funcion tamaño del mono
    public void tamanoMono() //Se utiliza la abstraccion
    {
        descripciondelTamanoMono();
    }

    //Funcion privada del tamaño del mono
    private void descripciondelTamanoMono() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un mono pequeño");
    }

    //Funcion de la vida del mono
    public void vidaDomesticaMono() //Se utiliza la abstraccion
    {
        caracteristicasMono();
        habilidadesdelMono();
    }

    //Funcion privada de las caracteristicas del mono
    private void caracteristicasMono() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es domestico");
        Console.WriteLine("Vive con una familia");
        Console.WriteLine("Le encanta trepar árboles");
        Console.WriteLine("Tiene pulgares");
        Console.WriteLine("Es divertido");
        Console.WriteLine("Es cariñoso");
        Console.WriteLine("Le gusta jugar");
    }

    //Funcion privada de las habilidades del mono
    private void habilidadesdelMono() //Se utiliza el encapsulamiento
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Mono");
        Console.WriteLine("====================");
        Console.WriteLine("Puede colgarse en los árboles con su cola");
        Console.WriteLine("Puede trepar grandes alturas");
        Console.WriteLine("Puede usar herramientas");
    }

}
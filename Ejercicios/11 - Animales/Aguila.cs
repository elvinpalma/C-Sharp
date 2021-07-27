//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Aguila:Aves //Se tiene una herencia de la clase Aves
{
    //Propiedades
    public bool Silvestre { get; set; }
    public string Raza { get; set; }
    public int Patas { get; set; }
    public int Alas { get; set; }

    //Constructor estableciendo que el valor lógico es verdadero
    public Aguila() //Se utiliza el polimorfismo
    {
        Silvestre = true;
    }

    //Constructor inicalizando las propiedades
    public Aguila(bool silvestre, string raza, string colorPlumaje, string nombre, int patas, string volar, int alas) //Se utiliza el polimorfismo
    {
        Silvestre = silvestre;
        Raza = raza;
        ColorPlumaje = colorPlumaje;
        Nombre = nombre;
        Patas = patas;
        Alas = alas;

    }

    //Funcion volar alto del águila
    public void volarAlto() //Se utiliza la abstraccion
    {
        Console.WriteLine("Vuelan alto");
    }

    //Funcion del tamaño del águila
    public void tamanoAguila() //Se utiliza la abstraccion
    {
        descripciondelTamanoAguila();
    }

    //Funcion privada del tamaño del águila
    private void descripciondelTamanoAguila() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un ave grande");
    }

    //Funcion de la vida del águila
    public void vidaSilvestredelAguila() //Se utiliza la abstraccion
    {
        caracteristicasAguila();
        habilidadesdelAguila();
    }

    //Funcion privada de las caracteristicas del águila
    private void caracteristicasAguila() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es Silvestre");
        Console.WriteLine("Vive en los bosques tropicales húmedos");
        Console.WriteLine("Es un animal carnívoro");
        Console.WriteLine("Tiene bastante fuerza");
        Console.WriteLine("Es el ave nacional de Panamá");
        Console.WriteLine("Es un animal protegido");
    }

    //Funcion privada de las habilidades del águila
    private void habilidadesdelAguila()
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Águila");
        Console.WriteLine("======================");
        Console.WriteLine("Es un animal cazador");
        Console.WriteLine("Sus garras son poderosas y fuertes");
    }  
}
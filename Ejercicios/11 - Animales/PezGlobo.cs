//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class PezGlobo:Peces //Se tiene una herencia de la clase Peces
{
    //Propiedades
    public bool Silvestre { get; set; }
    public string ColorEscamas { get; set; }
    
    //Constructor estableciendo que el valor lógico es verdadero
    public PezGlobo() //Se utiliza el polimorfismo
    {
        Silvestre = true;
    }

    //Constructor inicalizando las propiedades
    public PezGlobo(int numeroAletas, bool silvestre, string nombre, string colorEscamas) //Se utiliza el polimorfismo
    {
        NumeroAletas = numeroAletas;
        Nombre = nombre;
        Silvestre = silvestre;
        ColorEscamas = colorEscamas;
    }

    //Funcion inflarse
    public void inflarse() //Se utiliza la abstraccion
    {
        Console.WriteLine("Inflandose");
    }

    //Funcion del tamaño del pez globo
    public void tamanoPezGlobo() //Se utiliza la abstraccion
    {
        descripciondelTamanoPezGlobo();
    }

    //Funcion privada del tamaño del pez globo
    private void descripciondelTamanoPezGlobo() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es un pez mediano");
    }

    //Funcion de la vida del pez globo
    public void vidaSilvestredelPezGlobo() //Se utiliza la abstraccion
    {
        caracteristicasPezGlobo();
        habilidadesdelPezGlobo();
    }

    //Funcion privada de las caracteristicas del pez globo
    private void caracteristicasPezGlobo() //Se utiliza el encapsulamiento
    {
        Console.WriteLine("Es silvestre");
        Console.WriteLine("Vive en el mar");
        Console.WriteLine("Son robustos");
        Console.WriteLine("Es un animal omnivoro");
        Console.WriteLine("Es un animal curioso");
        Console.WriteLine("Es ágil y veloz");
    }

    //Funcion de las habilidades del pez globo
    private void habilidadesdelPezGlobo() //Se utiliza el encapsulamiento
    {
        Console.WriteLine();
        Console.WriteLine("Habilidades del Pez Globo");
        Console.WriteLine("======================");
        Console.WriteLine("Se infla como mecanismo de defensa");
        Console.WriteLine("Cuando se infla sus espinas se endurecen");
        Console.WriteLine("Es venenoso");
    }
}
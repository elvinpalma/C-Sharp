//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public abstract class Aves:Animal //Se tiene una herencia de la clase Animal
{  
    //Propiedades
    public string ColorPlumaje { get; set; }
    
    //Funcion volar
    public void volar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Volando");
    }  
}
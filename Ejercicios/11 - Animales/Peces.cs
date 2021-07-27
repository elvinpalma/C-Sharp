//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public class Peces:Animal //Se tiene una herencia de la clase Animal
{
    //Propiedades
    public int NumeroAletas { get; set; }   

    //Funcion nadar
    public void nadar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Nadando");
    }  
}
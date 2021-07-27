//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
public abstract class Mamiferos:Animal //Se tiene una herencia de la clase Animal
{
    //Propiedades
    public int Patas { get; set; }

    //Funcion caminar
    public void caminar() //Se utiliza la abstraccion
    {
        Console.WriteLine("Caminando...");
    }
}
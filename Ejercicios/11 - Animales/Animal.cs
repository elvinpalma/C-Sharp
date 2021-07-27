//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

//Se iniciia la clase
 public abstract class Animal
{
    //Propiedades
    public string Nombre { get; set; }

    //Funcion comer
    public void comer() //Se utiliza la abstraccion
    {
        Console.WriteLine("Comiendo");
    }
}
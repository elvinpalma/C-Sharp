//Elvin Noé Palma Hernández 20192001535

//Librerías a utilizar
using System;

//Se inicia la clase persona
public class Persona
{
    //Propiedades de la clase
    public int Codigo { get; set; }
    
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    //Función de enviar notificación
    public void enviarNotificacion()
    {
        Console.WriteLine("Correo enviado a: " + Nombre);
    }

}
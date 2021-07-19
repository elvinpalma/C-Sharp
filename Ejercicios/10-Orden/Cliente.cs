//Elvin Noé Palma Hernández 20192001535

//Se inicia la clase cliente con herencia en persona
public class Cliente:Persona
{
    //Propiedades de la clase
    public double Saldo { get; set; }

    //Constructor de la clase para inicializar las propiedades
    public Cliente(int codigo, string nombre, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
    }
}
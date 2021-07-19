//Elvin Noé Palma Hernández 20192001535

//Se inicia la clase vendedor con herencia en persona
public class Vendedor:Persona
{
    //Propiedades de la clase
    public string CodigoVendedor { get; set; }

    //Constructor de la clase para inicializar las propiedades
    public Vendedor(int codigo, string nombre, string codigoVendedor)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoVendedor = codigoVendedor;
    }
}
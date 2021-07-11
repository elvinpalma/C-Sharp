//Elvin Noé Palma Hernández 20192001535

//Clase Producto
public class Producto
{
    //Propiedades de la lista de prodcutos
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int Existencia { get; set; }

    //Constructor de la lista de prodcutos
    public Producto(string codigo, string descricion, int existencia)    
    {
        Codigo = codigo;
        Descripcion = descricion;
        Existencia = existencia;   
    }
}
//Elvin Noé Palma Hernández 20192001535

//Se inicia la clase producto
public class Producto
{
    //Propiedades de la clase
    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }

    //Constructor de la clase para inicializar las propiedades
    public Producto(int codigo, string descripcion, double precio)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Precio = precio;
    }
}
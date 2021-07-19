//Elvin Noé Palma Hernández 20192001535

//Se inicia la clase orden detalle
public class OrdenDetalle
{
    //Propiedades de la clase
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Producto Producto { get; set; }

    //Constructor de la clase para inicializar las propiedades    
    public OrdenDetalle(int codigo, int cantidad, Producto producto)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Producto = producto;
        Precio = producto.Precio;
    }
}
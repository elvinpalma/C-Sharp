public class Producto
{
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int Existencia { get; set; }

    public Producto(string codigo, string descricion, int existencia)    
    {
        Codigo = codigo;
        Descripcion = descricion;
        Existencia = existencia;   
    }
}
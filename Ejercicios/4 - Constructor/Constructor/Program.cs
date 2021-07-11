using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto prodcuto1 = new Producto("Mouse", 200);
            Producto prodcuto2 = new Producto("Teclado", 300);
            Producto prodcuto3 = new Producto("Laptop", 10000);

            Console.WriteLine(prodcuto2.Descripcion + " " + prodcuto2.Precio.ToString());
        }
    }
}

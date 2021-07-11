//Elvin Noé Palma Hernández 20192001535

//Librerías a utilizar
using System;
using System.Collections.Generic;

//Clase Inventario
public class Inventario
{
     //Lista de productos que estan en el inventario 
    public List<Producto> ListadeProductos { get; set; }

    public Inventario()
    {
        //Estancia necesaria
        ListadeProductos = new List<Producto>();

        Producto a = new Producto("001", "iPhoneX", 0);  
        Producto b = new Producto("002", "Dell", 5);  
        Producto c = new Producto("003", "Monitor Samsung", 2);  
        Producto d = new Producto("004", "Mouse", 100);  
        Producto e = new Producto("005", "HeadSet", 25);  

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
    }

    //Función donde se muestra la lista de productos que están en el inventario
    public void listarProductos()
    {
        //Comando para limpiar la pantalla
        Console.Clear();
        Console.WriteLine("");

        //Mensaje mostrando los productos del inventario
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("******************");
        Console.WriteLine("");
        Console.WriteLine("Codigo, Descricion y Existencia");

        //Ciclo foreach para mostrar el inventario
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }

        //Comando para pausar el programa
        Console.ReadLine();
    }

    //Función donde se hacen los calculos correspondientes con respecto a la cantidad de productos
    //Es privada por que solo se utilizará en esta clase
    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento)
    {
        //Ciclo donde se están haciendo los diferentes movimientos en el inventario
        foreach (var producto in ListadeProductos)
        {
           if (producto.Codigo == codigo)
            {
                if (tipoMovimiento == "+")
                {
                    producto.Existencia = producto.Existencia + cantidad;
                } 
                else
                {
                    producto.Existencia = producto.Existencia - cantidad;
                }
                
            } 
        }
    }

    //Función donde se le aumenta los ingresos a la cantidad de productos al inventario
    public void ingresoDeInventario()
    {
        //Variables a utilizar
        string codigo = " ";
        string cantidad = " ";

        //Comando para limpiar la pantalla
        Console.Clear();
        Console.WriteLine("");

        //Mensaje para ingresar productos del inventario
        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        
        //Mensaje solicitando el código del producto
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine("");

        //Mensaje solicitando  la canitdad de producto a ingresar
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.WriteLine("");

        //Esta función hará que los movimientos del inventario sean positivo
        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

    //Función donde se le resta todas las salidas a la cantidad de productos del inventario
    public void salidaDeProductos()
    {
        //Variables a utilizar
        string codigo = " ";
        string cantidad = " ";

        //Comando para limpiar la pantalla
        Console.Clear();
        Console.WriteLine("");

        //Mensaje para indicar las salidas de los productos del inventario
        Console.WriteLine("Salida de Productos del Inventario");
        Console.WriteLine("**********************************");
        
        //Mensaje solicitando el código del producto
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine("");

        //Mensaje solicitando  la canitdad de producto a ingresar
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.WriteLine("");

        //Esta función hará que los movimientos del inventario sean negativo
        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }

    //Función donde se hacen los ajustes negativos, lo cual es restar la cantidad de productos del inventario
    public void ajusteNegativoDeInventario()
    {
        //Variables a utilizar
        string codigo = " ";
        string cantidad = " ";

        //Comando para limpiar la pantalla
        Console.Clear();
        Console.WriteLine("");

        //Mensaje para indicar los ajustes negativos del inventario
        Console.WriteLine("Ajuste Negativo del Inventario");
        Console.WriteLine("******************************");
        
        //Mensaje solicitando el código del producto
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine("");

        //Mensaje solicitando  la canitdad de producto a ingresar
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.WriteLine("");

        //Esta función hará que los movimientos del inventario sean negativo
        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }

    //Función donde se hacen los ajustes positivos, lo cual  es sumar la cantidad de productos del inventario
    public void ajustePositivoDeInventario()
    {
        //Variables a utilizar
        string codigo = " ";
        string cantidad = " ";

        //Comando para limpiar la pantalla
        Console.Clear();
        Console.WriteLine("");

        //Mensaje para indicar los ajustes positivos del inventario
        Console.WriteLine("Ajuste Positivo del Inventario");
        Console.WriteLine("******************************");
        
        //Mensaje solicitando el código del producto
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine("");

        //Mensaje solicitando  la canitdad de producto a ingresar
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        Console.WriteLine("");

        //Esta función hará que los movimientos del inventario sean positivo
        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }

}
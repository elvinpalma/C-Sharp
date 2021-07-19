//Elvin Noé Palma Hernández 20192001535

//Librerías a utilizar
using System;
using System.Collections.Generic;

//Se inicia la clase datos de prueba
public class DatosdePrueba
{
    //Propiedades de la clase
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    //Constructor de la clase para inicializar las propiedades
    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();
        
        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
        //cargarOrdenes();
    }

    //Función para cargar producto
    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(p3);
    }

    //Función para cargar clientes
    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Juan", "77777");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Pedro", "99999");
        ListadeClientes.Add(c2);
    }

    //Función para cargar vendedores
    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Jose", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Pablo", "v002");
        ListadeVendedores.Add(v2);
    }

    //Función para listar productos
    public void ListarProductos()
    {
        Console.Clear();

        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    //Función para listar clientes
    public void ListarClientes()
    {
        Console.Clear();

        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    //Función para listar vendedores
    public void ListarVendedores()
    {
        Console.Clear();

        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");

        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    //Función para crear la orden
    public void CrearOrden()
    {
        Console.Clear();

        Console.WriteLine("Creando Ordenes");
        Console.WriteLine("===============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        //Se busca al cliente en la lista de clientes
        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);
        //En caso de no encontrarlo, se ejecuta esta condición
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        }
        else
            {
                Console.WriteLine("Cliente: " + cliente.Nombre);
                Console.WriteLine("");   
            }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        //Se busca al vendedor en la lista de vendedores
        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        //En caso de no encontrarlo, se ejecuta esta condición
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        }
        else
            {
                Console.WriteLine("Vendedor: " + vendedor.Nombre);
                Console.WriteLine("");
            }

        //Contador de codigos de la lista de ordenes
        int nuevoCodigo = ListaOrdenes.Count + 1;

        //Se agrega una orden
        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            
            //Se busca el producto en la lista de productos
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
            //En caso de no encontrarlo, se ejecuta esta condición
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            }
            else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Producto Agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                    nuevaOrden.AgregarProducto(producto);
                }

            
            Console.WriteLine("");
            Console.WriteLine("Desea continuar? s/n ");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n")
            {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("**************************************************");
        Console.WriteLine("Subtotal de la orden es de: " + nuevaOrden.Subtotal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.Impuesto);
        Console.WriteLine("Total de la orden es de:    " + nuevaOrden.Total);
        Console.WriteLine("***************************************************");
        Console.ReadLine();
    }

    //Función para listar las ordenes
    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("Codigo  | Fecha                    | Subtotal   |  Impuesto  | Total");
            Console.WriteLine(orden.Codigo + "       | " + orden.Fecha + " | " + orden.Subtotal + "        | " + orden.Impuesto + "       | "+ orden.Total);
            Console.WriteLine("====================================================================");
            Console.WriteLine("Cliente | Vendedor");
            Console.WriteLine(orden.Cliente.Nombre + "   | " + orden.Vendedor.Nombre);
            Console.WriteLine("====================================================================");

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("    Descrion | Cantidad | Precio");
                Console.WriteLine("     " + detalle.Producto.Descripcion + "  | " + detalle.Cantidad + "       | " + detalle.Precio);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
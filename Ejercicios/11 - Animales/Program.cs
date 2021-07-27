//Elvin Noé Palma Hernández  20192001535

//Librería de a utilizar
using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos del perro
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Perro");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            Perro p = new Perro();
            p.Nombre = "Ranger";
            Console.WriteLine("Nombre del perro: " + p.Nombre);
            p.Raza = "Pastor Aleman";
            Console.WriteLine("Raza del perro: " + p.Raza);
            p.Patas = 4;
            Console.WriteLine("Número de patas: " + p.Patas);
            Console.Write("Que esta haciendo el perro?: Esta ");
            p.comer();
            Console.Write("Los perros andan ");
            p.caminar();
            p.tamanoPerro();
            Console.Write("Los perros le hacen: ");
            p.ladrar();
            p.vidaDomesticaPerro();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para continuar");
            Console.WriteLine();

            Console.ReadLine();

            //Datos del gato
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Gato");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            Gato g = new Gato();
            g.Nombre = "Gary";
            Console.WriteLine("Nombre del gato: " + g.Nombre);
            g.Raza = "LaPerm";
            Console.WriteLine("Raza del gato: " + g.Raza);
            g.Patas = 4;
            Console.WriteLine("Número de patas: " + g.Patas);
            g.Pelaje = "Rizado";
            Console.WriteLine("Pelaje del gato: " + g.Pelaje);
            Console.Write("Que esta haciendo el gato?: Esta ");
            g.comer();
            Console.Write("Los gatos andan ");
            g.caminar();
            g.tamanoGato();
            Console.Write("Los gatos le hacen: ");
            g.maullar();
            g.vidaDomesticaGato();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para continuar");
            Console.WriteLine();

            Console.ReadLine();

            //Datos del mono
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Mono");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            Mono m = new Mono();
            m.Nombre = "Jorge";
            Console.WriteLine("El nombre del mono: " + m.Nombre);
            m.Raza = "Capuchino";
            Console.WriteLine("Raza del mono: " + m.Raza);
            m.Patas = 2;
            Console.WriteLine("Número de patas: " + m.Patas);
            m.Manos = 2;
            Console.WriteLine("Número de manos: " + m.Manos);
            Console.Write("Los monos se desplazan trepando y ");
            m.caminar();
            m.tamanoMono();
            Console.Write("Los Monos le hacen: ");
            m.aullar();
            m.vidaDomesticaMono();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para continuar");

            Console.ReadLine();

            //Datos del águila
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Águila");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            Aguila a = new Aguila();
            a.Nombre = "Dranzer";
            Console.WriteLine("El nombre del aguíla: " + a.Nombre);
            a.Raza = "Águila Harpía";
            Console.WriteLine("Raza del águila: " + a.Raza);
            a.Patas = 2;
            Console.WriteLine("Número de patas: " + a.Patas);
            a.Alas = 2;
            Console.WriteLine("Número de alas: " + a.Alas);
            a.ColorPlumaje = "Gris";
            Console.WriteLine("Su plumaje es de color: " + a.ColorPlumaje);
            Console.Write("Las águilas se desplazan ");
            a.volar();
            Console.Write("Las águilas ");
            a.volarAlto();
            a.tamanoAguila();
            a.vidaSilvestredelAguila();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para continuar");
            Console.WriteLine();

            Console.ReadLine();

            //Datos del loro
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Loro");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            Loro l = new Loro();
            l.Nombre = "Rebeca";
            Console.WriteLine("El nombre del loro: " + l.Nombre);
            l.Raza = "Loro Cariamarilla o Amazona autumnails";
            Console.WriteLine("Raza del loro: " + l.Raza);
            l.Patas = 2;
            Console.WriteLine("Número de patas: " + l.Patas);
            l.Alas = 2;
            Console.WriteLine("Número de alas: " + l.Alas);
            l.ColorPlumaje = "Verde";
            Console.WriteLine("Su plumaje de color: " + l.ColorPlumaje);
            Console.Write("Los loros se desplazan ");
            l.volar();
            Console.Write("Que hace el loro? Esta ");
            l.hablar();
            l.tamanoLoro();
            l.vidaDomesticadelLoro();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para continuar");
            Console.WriteLine();

            Console.ReadLine();

            //Datos del pez globo
            Console.Clear();
            Console.WriteLine("         Caracteristicas del Pez Globo");
            Console.WriteLine("==============================================");
            Console.WriteLine("");

            //Se inicializa la estancia necesaria
            PezGlobo pg = new PezGlobo();
            pg.Nombre = "Pops";
            Console.WriteLine("El nombre del pez globo: " + pg.Nombre);
            pg.NumeroAletas = 5;
            Console.WriteLine("El pez globo tiene esta cantidad de aletas: " + pg.NumeroAletas);
            pg.ColorEscamas = "Verde con puntos negros";
            Console.WriteLine("El color del pez globo es: " + pg.ColorEscamas);
            Console.Write("El pez globo se desplaza ");
            pg.nadar();
            Console.Write("El pez globo se defiende de sus depredadores ");
            pg.inflarse();
            pg.tamanoPezGlobo();
            pg.vidaSilvestredelPezGlobo();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Presiones Enter para salir");
            Console.WriteLine();

            Console.ReadLine();

            Console.Clear();
        }
    }
}

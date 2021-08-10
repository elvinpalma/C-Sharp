//Elvin Noé Palma Hernández 20192001535

//Se inicia la claes Estudiante con herencia
public class Estudiante:Persona // Se utiliza la herencia
{
    //Propiedades de la clase
    public int CodigoEstudiante { get; set; }

    //Constructor inicializando las propiedades
    public Estudiante(int codigoEstudiante, string nombre, string apellido) // Se utiliza el polimorfismo
    {
        CodigoEstudiante = codigoEstudiante;
        Nombre = nombre;
        Apellido = apellido;
    }
}
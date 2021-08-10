//Elvin Noé Palma Hernández 20192001535

//Se inicia la clase asignaturas
public class Asignaturas
{
    //Propiedades de la clase
    public int CodigoAsinagtura { get; set; }
    public string NombreAsignatura { get; set; }
    public int Nota1 { get; set; }
    public int Nota2 { get; set; }
    public int Nota3 { get; set; }
    public int Nota4 { get; set; }    
    public double NotaPromedio { get; set; }

    //Constructor inicializando las propiedades
    public Asignaturas(int codigoAsignatura, string nombreAsignatura) // Se utiliza polimorfismo
    {
        CodigoAsinagtura = codigoAsignatura;
        NombreAsignatura = nombreAsignatura;
    }

    //Función para calificar
    public void Calificar() // Se utiliza la abstracción
    {
        Nota1 = 0;
        Nota2 = 0;
        Nota3 = 0;
        Nota4 = 0;

        NotaPromedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        
    }
}
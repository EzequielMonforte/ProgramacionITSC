using System;
namespace Console
{
public class Persona{

    public Persona()
    {
        
    }
    private string nombre;
    private string apellido;
    private string tipoDni;
    private string dni;
    private DateTime fechaNacimiento;
    private Direccion direccion;
    private string cuit;
    
    public TimeSpan ObtenerEdad(){

        return fechaNacimiento.Subtract(DateTime.Now);
    }

    public string  Nombre { get; set; }
    public string  Apellido { get; set; }
    public string TipoDni { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public Direccion Direccion { get; set; }
    public string Cuit { get; set; }

    
}
 
public class Direccion{

    public string calle { get; set; }
    public string nro {get; set;}
    public string barrio { get; set; }
    public string  provincia { get; set; }
}
}
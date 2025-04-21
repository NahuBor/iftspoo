public class Empleado
{
    private string nombre;
    private string apellido;
    private string telefono;
    private string email;
    private int dni;
    private double sueldo;

    public Empleado(string nombre, string apellido, string telefono, string email, int dni, double sueldo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.telefono = telefono;
        this.email = email;
        this.dni = dni;
        this.sueldo = sueldo;
    }

    public string GetNombre() {
        return nombre;
    }
    public string GetApellido() {
        return apellido;
    }
    public string GetTelefono() {
        return telefono;
    }
    public string GetEmail() {
        return email;
    }
    public int GetDni() {
        return dni;
    }
    public double GetSueldo()  {
        return sueldo;
    }
}
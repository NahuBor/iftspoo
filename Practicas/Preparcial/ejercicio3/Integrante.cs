public class Integrante {
    public string nombre;
    public int edad;
    public int antiguedadEnAños;

    public Integrante (string nombre, int edad, int antiguedadEnAños) {
        this.nombre = nombre;
        this.edad = edad;
        this.antiguedadEnAños = antiguedadEnAños;
    }

    public void SumarAntiguedad(int cantidad) {
        if (cantidad > antiguedadEnAños) {
            antiguedadEnAños += cantidad;
        } else {
            Console.WriteLine("La antiguedad requeridad no es posible validarla.");
        }
    }

    public void SumarAntiguedad(int cantidad, string motivo) {
        this.antiguedadEnAños += cantidad;
        Console.WriteLine($"El motivo de la suma de antiguedad fue: {motivo}");
    }

    public virtual void MostrarInformacion() {
        Console.WriteLine("Datos de la persona:");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Antiguedad en años: {antiguedadEnAños}");
    }
}
 
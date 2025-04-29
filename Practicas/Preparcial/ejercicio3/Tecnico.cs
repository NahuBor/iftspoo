public class Tecnico : Integrante {
    public string especialidad;

    public Tecnico (string nombre, int edad, int antiguedadEnAños, string especialidad) : base (nombre, edad, antiguedadEnAños) {
        this.especialidad = especialidad;
    }

    public override void MostrarInformacion () {
        Console.WriteLine("Datos del Técnico:");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Antiguedad en Años: {antiguedadEnAños}");
        Console.WriteLine($"Especialidad: {especialidad}");
    }
}

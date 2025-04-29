public class Persona { 
    public string nombrePersona;
    private int edadPersona;
    public string dniPersona;

    public int getEdad() {
        return edadPersona;
    }

    public void setEdad(int edad) {
        this.edadPersona = edad;
    }

    public Persona() {}

    public Persona(string nombre, int edad) {
        this.nombrePersona = nombre;
        this.edadPersona = edad;
        this.dniPersona = "Dni desconocido";
    }

    public Persona (string nombre, int edad, string DNI) {
        this.nombrePersona = nombre;
        this.edadPersona = edad;
        this.dniPersona = DNI;
    }

    public void MostrarInfo () {
        Console.WriteLine($"Datos de la persona:");
        Console.WriteLine($"Nombre: {nombrePersona}");
        Console.WriteLine($"Edad: {edadPersona}");
        Console.WriteLine($"Dni: {dniPersona}");
    }
}
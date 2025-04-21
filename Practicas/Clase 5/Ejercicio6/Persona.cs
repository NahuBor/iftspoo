public class Persona {
    public string nombre;
    public string apellido;
    public int edad;
    public int dni;
    public string genero;

public Persona (string nombre, string apellido, int edad, int dni, string genero) {
    this.nombre = nombre;
    this.apellido = apellido;
    this.edad = edad;
    this.dni = dni;
    this.genero = genero;
}

public void CompararEdad(int edad) {
    if (!(edad > this.edad)) {
        Console.WriteLine($"La edad de {this.nombre} es mayor a la edad por la cual consultaste");
    } else {
        if (edad != this.edad) {
        Console.WriteLine($"La edad de {this.nombre} es menor a la edad por la cual consultaste");
        } else {
        Console.WriteLine($"La edad de {this.nombre} es igual a la edad por la cual consultaste");
    } 
    }
}
}
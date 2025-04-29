public class Jugador : Integrante {
    public string posicion;

    public Jugador (string nombre, int edad, int antiguedadEnAños, string posicion) : base (nombre, edad, antiguedadEnAños) {
        this.posicion = posicion;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Posición: {posicion}");
        Console.WriteLine("");
    }

    
}
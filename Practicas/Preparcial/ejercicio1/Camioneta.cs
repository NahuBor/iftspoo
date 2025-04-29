public class Camioneta : Vehiculo {
    public int cantDePuertas;
    public bool es4x4;

    public Camioneta(string marca, string modelo, int anio, int cantDePuertas, bool es4x4) : base (marca, modelo, anio) {
        this.cantDePuertas = cantDePuertas;
        this.es4x4 = es4x4;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cantidad de Puertas: {cantDePuertas}");
        if (!es4x4) {
            Console.WriteLine("¿Es 4x4?: No.");
        } else {
            Console.WriteLine("¿Es 4x4?: Si.");
        }    
        }
}

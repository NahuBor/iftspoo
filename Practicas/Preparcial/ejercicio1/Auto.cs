public class Auto : Vehiculo {
    public int cantidadDePuertas;
    public bool esAutomatico;

    public Auto(string marca, string modelo, int anio, int cantidadDePuertas, bool esAutomatico) : base(marca, modelo, anio){
        this.cantidadDePuertas = cantidadDePuertas;
        this.esAutomatico = esAutomatico;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cantidad de Puertas: {cantidadDePuertas}");
        if (esAutomatico) {
            Console.WriteLine("Es Automatico: Si");
        } else {
            Console.WriteLine("Es Automatico: No");
        }
    }
}
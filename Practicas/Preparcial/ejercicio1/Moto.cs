public class Moto : Vehiculo {
    public string tipoDeManubrio;

    public Moto (string marca, string modelo, int anio, string tipoDeManubrio) : base (marca, modelo, anio) {
        this.tipoDeManubrio = tipoDeManubrio;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo de manubrio: {tipoDeManubrio}");
    }
}
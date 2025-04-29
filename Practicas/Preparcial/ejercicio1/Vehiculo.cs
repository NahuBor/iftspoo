public class Vehiculo {
    public string marca;
    public string modelo;
    public int anio;

    public Vehiculo(string marca, string modelo, int anio) {
        this.marca = marca;
        this.modelo = modelo;
        this.anio = anio;
    }

    public void CambiarMarcha() {
        Console.WriteLine("El vehiculo ha cambiado la marcha");
    }

    public virtual void MostrarInformacion() {
        Console.WriteLine($"Datos del vehiculo:");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Añó de fabricación:  {anio}");
    }
}
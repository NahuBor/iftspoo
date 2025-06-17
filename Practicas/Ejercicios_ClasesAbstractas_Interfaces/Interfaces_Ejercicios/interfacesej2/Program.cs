namespace InterfacesEj2;

class Program
{
    static void Main(string[] args)
    {
        IVehiculo[] vehiculos = new IVehiculo[3];
        vehiculos[0] = new Auto();
        vehiculos[1] = new Moto();
        vehiculos[2] = new Bicicleta();
        foreach (IVehiculo v in vehiculos) {
            v.Conducir();
            Console.WriteLine("");
        }
    }
}

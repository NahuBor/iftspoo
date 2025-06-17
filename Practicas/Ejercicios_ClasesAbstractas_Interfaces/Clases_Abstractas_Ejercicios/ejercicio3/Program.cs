namespace CAbstractas.ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car();
        vehicles[1] = new Truck();
        vehicles[2] = new Motorbike();
        foreach (Vehicle v in vehicles) {
            v.MostrarInfo();
            v.Arrancar();
            v.Acelerar();
            Console.WriteLine();
        }
    }
}

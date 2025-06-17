namespace CAbstractas.ejercicio3  {
    public class Truck : Vehicle {
        public override void Arrancar() {
            Console.WriteLine("El camion arranca");
        }
        public override void Acelerar()
        {
            Console.WriteLine("El camion acelera");
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("El vehiculo es un camion");
        }
    }
}
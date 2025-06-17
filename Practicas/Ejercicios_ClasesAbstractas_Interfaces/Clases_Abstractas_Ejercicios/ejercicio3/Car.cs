namespace CAbstractas.ejercicio3 {
    public class Car : Vehicle {
        public override void Arrancar () {
            Console.WriteLine("El coche arranca");
        }
        public override void Acelerar()
        {
            Console.WriteLine("El coche acelera");
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("El vehiculo es un auto");
        }
    }
}
namespace CAbstractas.ejercicio3 {
    public class Motorbike : Vehicle {
        public override void Arrancar() {
            Console.WriteLine("Arrancando la moto");
        }
        public override void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }
                public override void MostrarInfo()
        {
            Console.WriteLine("El vehiculo es una moto");
        }
    }
}
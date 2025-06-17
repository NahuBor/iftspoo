namespace CAbstractas.ejercicio4 {
    public class Cat : Animal {
        public override void AnimalSound() {
            Console.WriteLine("Meow");
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("Soy un gato");
        }
    }
}
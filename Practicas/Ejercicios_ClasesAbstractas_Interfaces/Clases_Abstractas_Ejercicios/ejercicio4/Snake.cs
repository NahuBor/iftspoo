namespace CAbstractas.ejercicio4 {
    public class Snake : Animal {
        public override void AnimalSound() {
            Console.WriteLine("tsss tsss");
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("Soy una serpiente");
        }
    }
}
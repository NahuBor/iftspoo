namespace CAbstractas.ejercicio4 {
    public class Dog : Animal {
        public override void AnimalSound() {
            Console.WriteLine("Gua! Gua!");
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("Soy un perro");
        }
    }
}
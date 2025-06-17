namespace CAbstractas.ejercicio1 {
    public class Square : Figure{
        public double side;

        public Square(double side) {
            this.side = side;
        }

        public override void ComputeArea() {
            Console.WriteLine($"El area del cuadrado es: {side * side}");
        }
    }
}
namespace CAbstractas.ejercicio1 {
    public class Circle : Figure {
        public double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override void ComputeArea()
        {
            Console.WriteLine($"El area del circulo es: {Math.PI * (radius * radius)}");
        }
    }
}
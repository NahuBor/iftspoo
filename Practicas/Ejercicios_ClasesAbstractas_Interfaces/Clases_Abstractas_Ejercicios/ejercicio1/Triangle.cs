namespace CAbstractas.ejercicio1 {
public class Triangle : Figure {
        public double baseTriangle;
        public double heightTriangle;

        public Triangle(double baseTriangle, double heightTriangle) {
            this.baseTriangle = baseTriangle;
            this.heightTriangle = heightTriangle;
        }

        public override void ComputeArea () {
            Console.WriteLine($"El area del triangulo es: {(baseTriangle * heightTriangle) / 2}");
        }

    }
}
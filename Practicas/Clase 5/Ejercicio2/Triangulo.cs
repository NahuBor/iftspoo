public class Triangulo : Figura {
    public double alturaDeTriangulo;
    public double baseDeTriangulo;

    public Triangulo(double alturaDeTriangulo, double baseDeTriangulo) {
        this.alturaDeTriangulo = alturaDeTriangulo;
        this.baseDeTriangulo = baseDeTriangulo;
    }

    public Triangulo() {

    }
    public override double CalcularArea()
    {
        return (this.alturaDeTriangulo * this.baseDeTriangulo) / 2;
    }
}
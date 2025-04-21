public class Cuadrado : Figura {
    public double lado;


    public Cuadrado (double lado) {
        this.lado = lado;
    }
    public override double CalcularArea()
    {
        return (this.lado * this.lado);
    }
}
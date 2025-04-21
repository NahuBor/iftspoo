public class Circulo : Figura {
    public double radio;

    public Circulo(double radio) {
        this.radio = radio;
    }
    public override double CalcularArea()
    {
        return (this.radio * this.radio) * Math.PI;
    }
}
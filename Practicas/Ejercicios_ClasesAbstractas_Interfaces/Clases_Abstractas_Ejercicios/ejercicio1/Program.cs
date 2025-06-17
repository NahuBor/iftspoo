namespace CAbstractas.ejercicio1;

class Program
{
    static void Main(string[] args)
    {   
        Triangle triangle1 = new Triangle(10,10);
        triangle1.ComputeArea();
        Circle circle1 = new Circle(10);
        circle1.ComputeArea();
        Square square1 = new Square(10);
        square1.ComputeArea();
    }
}

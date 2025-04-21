public class Program{

    public static void Main(string[] args) {
    Triangulo triangulo1 = new Triangulo(10.5, 12.5);
    Console.WriteLine($"El area del triangulo con el lado cuya base es: {triangulo1.baseDeTriangulo} y altura es: {triangulo1.alturaDeTriangulo} tiene un area de: {triangulo1.CalcularArea()}");
    Cuadrado cuadrado1 = new Cuadrado(10);
    Console.WriteLine($"El area del cuadrado con el lado cuya dimension es: {cuadrado1.lado} tiene un area de: {cuadrado1.CalcularArea()}");
    Circulo circulo1 = new Circulo(5);
    Console.WriteLine($"El area del circulo con el radio cuya dimension es: {circulo1.radio} tiene un area de: {circulo1.CalcularArea()}");
    }

}

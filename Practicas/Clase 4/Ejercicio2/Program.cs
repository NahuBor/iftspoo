namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {

        Calculadora ObtCalculadora = new Calculadora();

        // Dada la clase calculadora, utilizamos el metodo #1 Sumar(), que lleva dos parametros int" 

        Console.WriteLine("Metodo #1 de Sumar: A continuación se le pediran los dos numeros a sumar");
        Console.WriteLine("Escoja el numero #1");
        int primerNumero = int.Parse(Console.ReadLine());
        Console.WriteLine("Escoja el numero #2");
        int segundoNumero = int.Parse(Console.ReadLine());

        Console.WriteLine($"El resultado de la suma de {primerNumero} y {segundoNumero} es: {ObtCalculadora.Sumar(primerNumero, segundoNumero)}");

        // Dada la clase calculadora, utilizamos el metodo #2 Sumar(), que lleva tres parametros double" 

        Console.WriteLine("Metodo #2 de Sumar: A continuación se le pediran los 3 numeros tipo double a sumar");
        Console.WriteLine("Escoja el numero #1");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escoja el numero #2");
        double numero2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escoja el numero #3");
        double numero3 = double.Parse(Console.ReadLine());

        Console.WriteLine($"El resultado de la suma de {numero1}, {numero2} y {numero3} es: {ObtCalculadora.Sumar(numero1, numero2, numero3)}");


        // Dada la clase calculadora, utilizamos el metodo #3 Sumar(), que lleva tres parametros (string, int, int)" 

        Console.WriteLine("Metodo #3 de Sumar: A continuación se le pedira un mensaje y 2 numeros tipo int");
        Console.WriteLine("Escriba el mensaje:");
        string mensaje = Console.ReadLine();
        Console.WriteLine("Escoja el numero #1");
        int numMetodo3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escoja el numero #2");
        int num2Metodo3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"El mensaje fue el siguiente: {mensaje} y la suma entre {numMetodo3} y {num2Metodo3} es: {numMetodo3 + num2Metodo3}");

        // Dada la clase calculadora, utilizamos el metodo EsPar(), que lleva un parametro tipo int"

        Console.WriteLine("A continuación se le pedirá un numéro entero para comprobar si es par o no");
        Console.WriteLine("Ingrese el numero");
        int a = int.Parse(Console.ReadLine());
        if (ObtCalculadora.EsPar(a)) {
            Console.WriteLine("El numero es par.");
        } else {
            Console.WriteLine("El numero no es par.");
        }



    }
}

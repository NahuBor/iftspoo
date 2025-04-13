namespace Ejercicio2;

class Calculadora

    {
        public int Sumar(int a, int b) {
            return a + b;
        }

        public double Sumar(double a, double b, double c) {
            return a + b +c;
        }

        public void Sumar(string mensaje, int a, int b) {
            Console.WriteLine($"El mensaje es: {mensaje} y el resultado de la suma es: {a+b}");
        }

        public bool EsPar(int a) {
            if (a % 2 != 0) {
                return false;
            } else {
                return true;
            }
        }

    }


using System;

    class Program
    {
        static void Main(string[] args)
        {

        }  
    }

    public class Animal {

    public string nombre;
    public int edad;
    public float peso;
    public string especie;
    public float tamaño;
    public string habitat;
    public string genero;
    public string estadoDeSalud;
    public string tipoReproduccion;
    public int duracionDeVida;
        
    public void Comer() {}
    public void Moverse() {}
    public void Reproducirse() {}
    public void Crecer() {}
    }

    public class Reptil : Animal {

    public string tipoDeEscamas; 
    public bool puedeMudarDePiel;
    public bool esVenenoso;
    public string tiempoDeMuda;
    public bool tienePatas;

    public void MudarDePiel(bool puedeMudarDePiel) {
        if (puedeMudarDePiel == true) {
            Console.WriteLine("Comienza la muda de piel");
        } else {
            Console.WriteLine("El reptil que puede mudarse de piel");
        }
    }

    public void RegularTemperatura() {
        Console.WriteLine("El reptil regula la temperatura");
    }

    public void Cazar () {}

    public void Defenderse () {}

    public void Bramido () {}

    }

    public class Insecto : Animal {
    
    public bool cantPatas;
    public bool esVolador;
    public bool tieneMuda;
    public string tipoDePatas;
    public string tipoNido;
    public string tiempoDeMuda;

    public void Volar(bool esVolador) {
        if (esVolador == true) {
            Console.WriteLine("El insecto está volando");
        } else {
            Console.WriteLine("Este insecto no puede volar");
        }
    }

    public void CambiarFase () {
        Console.WriteLine("El insecto ha cambiado de fase");
    }

    public void Cazar() {}
    public void Defenderse() {}
    public void Rechinar() {}
  
}

using System;

namespace EjemploPersonaAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniliazamos una instancia Persona
            Persona persona_1 = new Persona();
            persona_1.nombre = "Carlos";
            persona_1.edad = 30;
            
            // ejecutamos metodo
            persona_1.Saludar();
            
            // Inicializamos una instancia Auto
            Auto auto1 = new Auto();
            auto1.marca = "Toyota";
            auto1.color = "Rojo";
            
            // ejecutamos metodo
            auto1.Encender();
            
        }
    }

    class Persona
    {
        // atributos 
        public string nombre;
        public int edad;

        // métodos
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre} y tengo {edad} años.");
        }
    }

    class Auto
    {
        // atributos 
        public string marca;
        public string color;

        // métodos
        public void Encender()
        {
            Console.WriteLine($"El {marca} de color {color} está encendido.");
        }
    }
}
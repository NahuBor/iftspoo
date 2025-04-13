namespace Ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();

        // Instanciamos un objeto de la clase Persona, con los atributos de nombre, edad y dni. 

        persona1.nombre = "naruto";
        persona1.SetEdad(30);
        persona1.dni = "42542913";

        persona1.MostrarDatos();

        // Instanciamos un objeto de la clase Persona con un constructor, y con atributos ya definimos dentro del mismo.

        Persona persona2 = new Persona();

        persona2.MostrarDatos();

        // Instaciamos un objeto de clase persona con solo el nombre mediante un constructor que reciba solo un parametro de tipo string.

        Persona persona3 = new Persona("Horacio");

        persona3.MostrarDatos();

        // Instanciamos un objeto de la clase Persona, con un constructor de 3 parametros. 

        Persona persona4 = new Persona("David", 40, "30123456");

        persona4.MostrarDatos();
    }
}

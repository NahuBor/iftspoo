using System.Diagnostics.Contracts;
namespace EjerciciosLindos_1 {
internal class Lector : Usuario {
    public Lector () :base () {}
    
    public Lector (string nombre, string mail) :base (nombre, mail) {

    }

    public override void VerPermisos() {
        Console.WriteLine($"Nombre del Lector: {GetNombre()}.");
        Console.WriteLine("Este usuario tiene permisos de Lector");
        Console.WriteLine("************************");
    }
}
}


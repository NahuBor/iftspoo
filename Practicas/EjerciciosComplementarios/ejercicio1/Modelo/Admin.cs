namespace EjerciciosLindos_1 {
internal class Admin : Usuario {

    public Admin () :base() {}
    public Admin (string nombre, string mail) : base (nombre, mail){
    }

    public override void VerPermisos () {
        Console.WriteLine($"Nombre del Admin: {GetNombre()}.");
        Console.WriteLine("Este usuario tiene permisos de Admin");
        Console.WriteLine("************************");
    }
}
}
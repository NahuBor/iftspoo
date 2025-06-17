namespace EjerciciosLindos_1 {
internal class Editor : Usuario {
    public Editor () : base() {}

    public Editor (string nombre, string mail) :base (nombre, mail) {
    }

    public override void VerPermisos()
    {
        Console.WriteLine($"Nombre del Editor: {GetNombre()}.");
        Console.WriteLine($"Este usuario tiene permisos de Editor");
        Console.WriteLine("************************");
    }
}
}

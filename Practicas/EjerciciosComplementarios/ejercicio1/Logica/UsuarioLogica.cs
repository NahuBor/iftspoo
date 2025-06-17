using System.Linq.Expressions;

namespace EjerciciosLindos_1 {
internal class UsuarioLogica {
    private List<Usuario> usuarios = new List<Usuario>();

    public UsuarioLogica () {}
    public void AgregarUsuario (string nombre, string mail) {
        Console.WriteLine("Comprobando validez de los datos ingresados...");
        if (nombre == null && nombre.Any(char.IsDigit)) {
            Console.WriteLine("Nombre no valido.");
        } else {
            if (mail == null) {
                Console.WriteLine("Mail no valido.");
            } else {
        int num;
        bool opcion;
        Console.WriteLine($"El nombre {nombre} es valido, y el mail {mail} tambien");
        Console.WriteLine("A continuacion se le pedira el tipo de usuario que será esta persona");
        do {
            Console.WriteLine("Elija el tipo de usuario a agregar (1. Admin, 2. Editor, 3.Lector)");
            opcion = int.TryParse(Console.ReadLine(), out num);
        } while (!opcion && (num > 3 || num < 1));
        
        switch (num) {
            case 1: {
                usuarios.Add(new Admin(nombre, mail));
                Console.WriteLine("Usuario tipo admin agregado.");
                Console.WriteLine("----------------------------");
                break;
            }
            case 2: {
                usuarios.Add(new Editor(nombre, mail));
                Console.WriteLine("Usuario tipo editor agregado.");
                Console.WriteLine("----------------------------");
                break;
            }
            case 3: {
                usuarios.Add(new Lector(nombre, mail));
                Console.WriteLine("Usuario tipo lector agregado.");
                Console.WriteLine("----------------------------");
                break;
        }  
            }
        }
    } 
}


    public void MostrarPermisos () {
        foreach (Usuario u in usuarios) {
            u.VerPermisos();
        }
    }
}
}
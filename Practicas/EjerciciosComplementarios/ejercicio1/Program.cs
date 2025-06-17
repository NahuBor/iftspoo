using EjerciciosLindos_1; 
internal class Program
{
    static void Main(string[] args)
    {
        UsuarioLogica userLogica = new UsuarioLogica();
        userLogica.AgregarUsuario("Juan","juancito@gmail.com.ar");
        userLogica.AgregarUsuario("Nau","naucrack@xd.com.ar");
        userLogica.AgregarUsuario("Carlitos","carlitoslacabra@yahoo.com");
        userLogica.MostrarPermisos();
    }
}


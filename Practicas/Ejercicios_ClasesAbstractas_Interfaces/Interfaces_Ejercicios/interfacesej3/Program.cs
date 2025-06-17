namespace Interfacesej3;

class Program
{
    static void Main(string[] args)
    {
        UsuarioLogica userControlador = new UsuarioLogica();
        // Creamos un registro de un usuario con el metodo Post y lo guardamos en la base de datos ficticia (clase Usuario).
        userControlador.Post("Id: `30`, Nombre: `Nahuel`, Apellido: `Borja`, Mail: `nau@ymail.com`, Edad: `25`");
        // Utilizamos el metodo Get para obtener la info del usuario.
        userControlador.Get(30);
        // Utilizamos el metodo Put para reemplazar un campo tipo string de nuestro registro
        // En este caso el campo "Nombre";
        userControlador.Put(30, "Juan");
        // Comprobamos el cambio.
        userControlador.Get(30);
        // Utilizamos el metodo Delete para eliminar un registro de nuestra base de datos ficticia.
        userControlador.Delete(30);
        // Comprobamos el cambio.
        userControlador.Get(30);
    }
}

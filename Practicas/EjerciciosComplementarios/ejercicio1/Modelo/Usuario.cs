namespace EjerciciosLindos_1 {
internal abstract class Usuario {
    private string nombre;
    private string mail;
    
    public Usuario () {
    }

    public Usuario (string nombre, string mail) {
        this.nombre = nombre;
        this.mail = mail;
    }
    public abstract void VerPermisos ();

    public string GetNombre () {
        return nombre;
    } 
    public string GetMail () {
        return mail;
    }
}
}

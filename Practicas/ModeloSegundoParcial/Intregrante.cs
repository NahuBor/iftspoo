namespace mp {
    internal abstract class Integrante {
        private string nombre;
        private string apellido;
        private int edad;

    public Integrante () {}
    public Integrante (string nombre, string apellido, int edad) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    } 

    public abstract void MostrarInfo(); 
    public string GetNombre () {
        return nombre;
    }
    public string GetApellido () {
        return apellido;
    }
    public int GetEdad () {
        return edad;
    }

    public void SetNombre (string nombre) {
        this.nombre = nombre;
    }
    public void SetApellido (string apellido) {
        this.apellido = apellido;
    }
    public void SetEdad (int edad) {
        this.edad = edad;
    }
}
}
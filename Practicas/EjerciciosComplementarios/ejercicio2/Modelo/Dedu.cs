namespace ej2 {
internal class Dedu : IUsuarioModelo {
    private string rol = "Dedu";
    public Dedu () {}

    public string GetRol () {
        return rol;
    }
    public List<string> ListarModulos() {
        return new List<string> {"Gestión de cursos", "Estadisticas", "Soporte", "Educación"};
    }
}    
}
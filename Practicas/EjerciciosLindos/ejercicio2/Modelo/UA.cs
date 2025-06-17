namespace ej2 {
internal class UA : IUsuarioModelo {
    private string rol = "UA";
    public UA () {}

    public string GetRol () {
        return rol;
    }
    public List<string> ListarModulos() {
        return new List<string> {"Gestión de cursos", "Estadisticas"};
    }
}    
}
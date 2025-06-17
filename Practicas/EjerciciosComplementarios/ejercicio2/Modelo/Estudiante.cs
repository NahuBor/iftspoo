namespace ej2 {
internal class Estudiante : IUsuarioModelo {
    private string rol = "Estudiante";

    public Estudiante () {}

    public string GetRol () {
        return rol;
    }
    public List<string> ListarModulos () {
        return new List<string> {"Cursos", "Cronograma"};
    }
}
}

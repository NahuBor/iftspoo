namespace ej3 {
    internal class Curso : IRegistrable {
        private string nombre;


        public Curso (string nombre) {
            this.nombre = nombre;
        }

        public string GetNombre() {
            return nombre;
        }
        public string ObtenerLog() {
            return $"*** Se ha actualizado el Log del curso: {GetNombre()} ***";
        }
    }
}
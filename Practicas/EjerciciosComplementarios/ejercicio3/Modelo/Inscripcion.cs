namespace ej3 {
    internal class Inscripcion : IRegistrable {
        private string nombre;
        public Inscripcion (string nombre) {
            this.nombre = nombre;
        }

        public string GetNombre() {
            return nombre;
        }
        public string ObtenerLog() {
            return $"*** Se ha actualizado el Log de la inscripcion: {GetNombre()} ***";
        }
    }
}
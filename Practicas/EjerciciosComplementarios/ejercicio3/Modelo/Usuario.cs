namespace ej3 {
    internal class Usuario : IRegistrable {
        private string nombre ;
        public Usuario (string nombre) {
            this.nombre = nombre;
        }

        public string GetNombre() {
            return nombre;
        }
        public string ObtenerLog() {
            return $"*** Se ha actualizado el Log del usuario: {GetNombre()} ***";
        }
    }
}
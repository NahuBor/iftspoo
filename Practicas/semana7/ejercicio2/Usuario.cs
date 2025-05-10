namespace sem7_ejercicio2 {
    internal class Usuario {

        private string username;
        private string nombre;
        private string apellido;

        public Usuario(string username, string nombre, string apellido) {
            this.username = username;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string GetUsername() {
            return username;
        }
        public string GetApellido() {
            return apellido;
        }

        public string GetNombre() {
            return nombre;
        }

        public virtual void EditarForo(string nombreForo) {
            Console.WriteLine($"Soy un usuario y edito mi respuesta en el foro {nombreForo}");
        }
    }
}
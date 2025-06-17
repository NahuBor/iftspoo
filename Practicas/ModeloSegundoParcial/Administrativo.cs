namespace mp {
    internal class Administrativo : Integrante {
        private string profesion;
        private string rol;

        public Administrativo (string nombre, string apellido, int edad, string profesion, string rol) :base (nombre, apellido, edad) {
            this.profesion = profesion;
            this.rol = rol;
        }

        public string GetProfesion () {
            return profesion;
        }
        public string GetRol () {
            return rol;
        }

         public override void MostrarInfo() {
            Console.WriteLine($"*** Información del Administrativo ***");
            Console.WriteLine($"Nombre: {GetNombre()}");
            Console.WriteLine($"Apellido: {GetApellido()}");
            Console.WriteLine($"Edad: {GetEdad()}");
            Console.WriteLine($"Profesión: {GetProfesion()}");
            Console.WriteLine($"Rol: {GetRol()}");
        }
    }
}
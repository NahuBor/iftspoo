namespace sem7_ejercicio1 {
internal class Persona {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        public Persona(string nombre, string apellido, string dni, int edad) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public virtual string Presentarse() {
           return $"Hola, soy {nombre} {apellido} y tengo {edad} años.";
        }
        public string GetNombre() {
            return nombre;
        }

        public string GetApellido() {
            return apellido;
        }

        public string GetDni() {
            return dni;
        }

        public int GetEdad() {
            return edad;
        }
    }
}
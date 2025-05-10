namespace sem7_ejercicio1 {
    internal class Alumno : Persona {
        private string instituto;

        public Alumno (string nombre, string apellido, string dni, int edad, string instituto):base(nombre,apellido,dni,edad) {
            this.instituto = instituto;
        }

        public override string Presentarse()  {
            return $"{base.Presentarse()} y soy alumno del Instituto: {instituto}.";
        }
        public string GetInstituto() {
            return this.instituto;
        }

    }
}
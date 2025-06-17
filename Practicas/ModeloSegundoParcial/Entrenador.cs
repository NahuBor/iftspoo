namespace mp {
    internal class Entrenador : Integrante, IMotivador {
        private int añosDeExp;

        public Entrenador(string nombre, string apellido, int edad, int añosDeExp) : base (nombre, apellido, edad) {
            this.añosDeExp = añosDeExp;
        }

        public override void MostrarInfo () {
            Console.WriteLine("*** Entrenador ***");
            Console.WriteLine($"Nombre: {GetNombre()}");
            Console.WriteLine($"Apellido: {GetApellido()}");
            Console.WriteLine($"Edad: {GetEdad()}");
            Console.WriteLine($"Años de experiencia: {GetAñosDeExp()}");
            Motivar();
        }

        public void Motivar() {
            Console.WriteLine($"El Entrenador: {GetNombre()} se pone a motivar!");
        }
        public int GetAñosDeExp () {
            return añosDeExp;
        }
    }
}
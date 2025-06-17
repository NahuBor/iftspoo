
namespace mp {
    internal class Jugador : Integrante, IMotivador {
        private int posicion;
        private string categoria;

        public Jugador (string nombre, string apellido, int edad, int posicion, string categoria) : base (nombre, apellido, edad) {
            this.posicion = posicion;
            this.categoria = categoria;
        }

        public override void MostrarInfo () {
            Console.WriteLine("*** Jugador ***");
            Console.WriteLine($"Nombre: {GetNombre()}");
            Console.WriteLine($"Apellido: {GetApellido()}");
            Console.WriteLine($"Edad: {GetEdad()}");
            Console.WriteLine($"Posicion: {GetPosicion()}");
            Console.WriteLine($"Categoria: {GetCategoria()}");
            Motivar();
        }

        public void Motivar() {
            Console.WriteLine($"El jugador: {GetNombre()} se pone a motivar!");
        }
        public int GetPosicion () {
            return posicion;
        }
        public string GetCategoria () {
            return categoria;
        }
    }
}
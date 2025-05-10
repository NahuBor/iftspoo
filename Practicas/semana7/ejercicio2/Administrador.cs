namespace sem7_ejercicio2 {
    internal class Administrador : Usuario {

        public Administrador(string username, string nombre, string apellido) :base (username, nombre, apellido) {
        }

        public override void EditarForo(string nombreForo)
        {
            Console.WriteLine("Soy el administrador y puedo configurar el foro completo");
        }
    }    
}
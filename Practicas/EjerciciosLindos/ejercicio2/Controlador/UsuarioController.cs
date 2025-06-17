namespace ej2 {
    internal class UsuarioController {
        private List<IUsuarioModelo> usuarios = new List<IUsuarioModelo> {
            new Dedu(),
            new Estudiante(),
            new UA()
        };

        public void MostrarModulos () {
            foreach (IUsuarioModelo u in usuarios) {
                Console.WriteLine($"Modulo de usuario de rol {u.GetRol()}: ");
                Console.WriteLine(String.Join(", ", u.ListarModulos()));
            }
        }  

        public UsuarioController () {}
    }
}
namespace sem7_ejercicio2 {

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario("fernanditocrackgod", "fernado", "alvarez");
            usuario1.EditarForo("Doo");
            Administrador administrador1 = new Administrador ("raulito_el_profe_god", "raul", "gonzales");
            administrador1.EditarForo("Doo");
        }
    }
}
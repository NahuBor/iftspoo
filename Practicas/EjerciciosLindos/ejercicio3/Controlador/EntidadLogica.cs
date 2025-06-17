namespace ej3 {
    internal class EntidadLogica {
        List <IRegistrable> entidades = new List <IRegistrable> {
            new Curso("Javascript --- Programación Funcional"),
            new Inscripcion("Num #450"),
            new Usuario("Juan")
        };
        public void GenerarReportes () {
            foreach (IRegistrable i in entidades) {
                Console.WriteLine($"{i.ObtenerLog()}");
            }
        }
    }
}
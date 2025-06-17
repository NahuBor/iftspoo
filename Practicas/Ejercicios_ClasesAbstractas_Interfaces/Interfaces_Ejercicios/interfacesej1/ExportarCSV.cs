namespace InterfacesEj1  {
    public class ExportarCSV : IExportable {
        public void Exportar(string contenido) {
            Console.WriteLine("Exportando a CSV");
        }
    }
}
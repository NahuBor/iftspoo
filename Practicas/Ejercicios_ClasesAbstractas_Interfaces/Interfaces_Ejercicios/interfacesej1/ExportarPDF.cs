namespace InterfacesEj1  {
    public class ExportarPDF : IExportable {
        public void Exportar(string contenido) {
            Console.WriteLine("Exportando a PDF");
        }
    }
}
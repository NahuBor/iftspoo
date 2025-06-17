namespace InterfacesEj1  {
    public class ExportarExcel : IExportable {
        public void Exportar(string contenido) {
            Console.WriteLine("Exportando a Excel");
        }
    }
}
namespace InterfacesEj1;

class Program
{
    static void Main(string[] args)
    {
        string contenido = "Este es el informe de las personas encuestadas2";

        IExportable[] exportadores = new IExportable[3];
        exportadores[0] = new ExportarCSV();
        exportadores[1] = new ExportarPDF();
        exportadores[2] = new ExportarExcel();

        foreach (IExportable e in exportadores) {
            e.Exportar(contenido);
        }
    }
}

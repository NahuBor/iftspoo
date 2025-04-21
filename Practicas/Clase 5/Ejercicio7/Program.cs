public class Program {

    public static void Main(string[] args) {
    Vagon vagon = new Vagon(150, 100, 20);
    vagon.Acelerar(20);
    vagon.Frenar();
    vagon.BajarPasajeros(20);
    vagon.SubirPasajeros(50);
    vagon.VagonLleno();

    Vagon vagon2 = new Vagon(150, 100, 20);
    vagon2.Acelerar(20);
    vagon2.Frenar();
    vagon.BajarPasajeros(20);
    vagon.SubirPasajeros(120);
    vagon.VagonLleno();
    }
}


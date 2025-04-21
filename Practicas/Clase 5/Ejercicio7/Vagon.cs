public class Vagon : Tren {
    public int capMax;
    public int pasajeros;

    public bool tieneEspacioDisponible;

    public Vagon(int velocidad, int capacidadMax, int pasajeros) :base (velocidad) {
        this.capMax = capacidadMax;
        this.pasajeros = pasajeros;
    }
    public void BajarPasajeros (int cantABajar) {
        this.pasajeros -= cantABajar;
        Console.WriteLine($"Han bajado {cantABajar} pasajeros.");
    }
    public bool SubirPasajeros(int cantidadASubir) {
        if (cantidadASubir + pasajeros > capMax) {
             cantidadASubir = cantidadASubir - (-1 * (capMax - (cantidadASubir + pasajeros)));
            Console.WriteLine($"Han subido {cantidadASubir} pasajeros.");
            this.pasajeros += cantidadASubir;
             return tieneEspacioDisponible = false;
        }
        else {
            pasajeros += cantidadASubir;
            return tieneEspacioDisponible = true;
            Console.WriteLine("Han subido {cantidadASubir} pasajeros.");
        }
    }
    public void VagonLleno () {
        if (tieneEspacioDisponible == false) {
            Console.WriteLine($"Vagon lleno. Hay la cantidad de {pasajeros} pasajeros, y la max es: {capMax}");
        } else {
            Console.WriteLine($"Todavia hay espacio. Hay la cantidad de {pasajeros} pasajeros, y la max es: {capMax}");
        }
    }
    
}
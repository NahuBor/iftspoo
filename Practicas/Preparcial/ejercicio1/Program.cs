public class Program {
    public static void Main(string[] args) {
        // Instanciación subclase Auto

        Auto auto1 = new Auto("toyota", "aes 600", 2000, 4, true);
        auto1.CambiarMarcha();
        auto1.MostrarInformacion();

        // Instanciación subclase Moto

        Moto moto1 = new Moto("honda", "slx 120", 2019, "Manubrio desconocido xd");
        moto1.CambiarMarcha();
        moto1.MostrarInformacion();

        // Instanciación subclase Camioneta

        Camioneta camioneta1 = new Camioneta("Ford", "Modelo Familiar", 2022, 4, true);
        camioneta1.CambiarMarcha();
        camioneta1.MostrarInformacion();
    }
}

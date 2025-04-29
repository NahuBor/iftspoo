public class Program {
    public static void Main(string[] args) {
        Persona personita1 = new Persona();

        personita1.nombrePersona = "Jorgitooo";
        personita1.setEdad(24);
        personita1.dniPersona = "20423123";
        personita1.MostrarInfo();

        Persona personita2 = new Persona("Nicyy", 21);
        personita2.MostrarInfo();

        Persona personita3 = new Persona("Cinthia", 28, "12345678");
        personita3.MostrarInfo();
    }
}

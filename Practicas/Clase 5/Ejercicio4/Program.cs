
public class Program
{
    public static void Main(string[] args)
    {
        Programador programador1 = new Programador(
            "Yoana", "Perez", "123456789", "yoana@gmail.com", 12345678, 50000,
            "Backend", true, true, 5, "C#", "Senior", 2
        );
        programador1.MostrarInformacionEmpleado();
    }
}
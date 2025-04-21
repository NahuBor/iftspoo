namespace ejercicio3
{
public class Program
{
    public static void Main(string[] args)
    {
        // CuentaMayor
        CuentaMayor cuenta1 = new CuentaMayor("cuenta_001", "Luciana Ruiz", 3000, "Activa", 22);
        cuenta1.MostrarInformacion();
        cuenta1.EsMayorDeEdad();
        cuenta1.IngresarMonto(500);
        cuenta1.RetirarMonto(1000);
        Console.WriteLine();

        // CuentaEstudiante
        CuentaEstudiante cuenta2 = new CuentaEstudiante("cuenta_002", "Ezequiel Fernández", 1000, "Activa");
        cuenta2.MostrarInformacion();
        cuenta2.IngresarMonto(200);
        cuenta2.RetirarMonto(150);
        Console.WriteLine($"Saldo final de {cuenta2.GetNombre()}: ${cuenta2.GetSaldo()}");
    }
}    
}
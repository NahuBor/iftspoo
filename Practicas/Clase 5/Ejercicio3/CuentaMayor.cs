namespace ejercicio3
{
public class CuentaMayor : Cuenta
{
    private int edadTitular;

    public CuentaMayor(string nroCuenta, string nombre, int saldoInicial, string estado, int edad)
        : base(nroCuenta, nombre, saldoInicial, estado)
    {
        this.edadTitular = edad;
    }

    public void EsMayorDeEdad()
    {
        if (edadTitular >= 18)
        {
            Console.WriteLine($"{GetNombre()} es mayor de edad.");
        }
        else
        {
            Console.WriteLine($"{GetNombre()} es menor de edad.");
        }
    }

    public int GetEdadTitular() { return edadTitular; }
}
}
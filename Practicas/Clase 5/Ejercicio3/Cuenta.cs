namespace ejercicio3
{
public class Cuenta
{
    private string nro_cuenta;
    private string nombre;
    private int saldo;
    private string estado_cuenta;

    public Cuenta(string nroCuenta, string nombre, int saldoInicial, string estado)
    {
        this.nro_cuenta = nroCuenta;
        this.nombre = nombre;
        this.saldo = saldoInicial;
        this.estado_cuenta = estado;
    }

    public void IngresarMonto(int montoASumar)
    {
        if (montoASumar > 0)
        {
            saldo += montoASumar;
            Console.WriteLine($"Se ingresaron ${montoASumar}. Nuevo saldo: ${saldo}");
        }
        else
        {
            Console.WriteLine("Monto inválido.");
        }
    }

    public void RetirarMonto(int montoARestar)
    {
        if (montoARestar <= saldo && montoARestar > 0)
        {
            saldo -= montoARestar;
            Console.WriteLine($"Se retiraron ${montoARestar}. Saldo restante: ${saldo}");
        }
        else
        {
            Console.WriteLine("No hay suficiente saldo o el monto no es válido.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información de la Cuenta:");
        Console.WriteLine($"Número de cuenta: {nro_cuenta}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Saldo: ${saldo}");
        Console.WriteLine($"Estado: {estado_cuenta}");
    }

    public string GetNroCuenta() { return nro_cuenta; }
    public string GetNombre() { return nombre; }
    public int GetSaldo() { return saldo; }
    public string GetEstadoCuenta() { return estado_cuenta; }
}
}
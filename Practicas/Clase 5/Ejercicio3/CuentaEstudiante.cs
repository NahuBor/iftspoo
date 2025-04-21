namespace ejercicio3
{
public class CuentaEstudiante : Cuenta
{
    public CuentaEstudiante(string nroCuenta, string nombre, int saldoInicial, string estado)
        : base(nroCuenta, nombre, saldoInicial, estado) { }
}
}
using System;

    class Program
    {
        static void Main(string[] args)
        {

        CajeroAutomatico cajero1 = new CajeroAutomatico();
        cajero1.ubicacion = "Av. San jose  123";
        cajero1.bancoAsociado = "Banco Nación";
        cajero1.numCajero = "BN-001";
        cajero1.efectivoDisponible = 100000;
        cajero1.estaOperativo = true;

        CuentaBancaria cuenta1 = new CuentaBancaria();
        cuenta1.titular = "Juan Ernesto";
        cuenta1.cbu = "12345678";
        cuenta1.dni = "40123456";
        cuenta1.saldo = 50000;
        cuenta1.tipoCuenta = "Caja de ahorro";
        cuenta1.banco = "Banco Nación";

        
        cajero1.MostrarEstado();

        cajero1.Retirar(cuenta1, 3000);

        cuenta1.MostrarSaldo();

        cajero1.MostrarEstado();
        }  


    }

    public class CajeroAutomatico {

    public string ubicacion;           
    public string bancoAsociado;         
    public string numCajero;          
    public double efectivoDisponible;    
    public bool estaOperativo;        

   public void MostrarEstado()
    {
        Console.WriteLine($"Cajero en: {ubicacion} | Banco: {bancoAsociado}");
        Console.WriteLine($"Efectivo disponible: ${efectivoDisponible}");
        if (estaOperativo) {
            Console.WriteLine("El sistema esta operativo"); 
        } else  {
            Console.WriteLine("No esta disponible.");
        }
    }

     public void Retirar(CuentaBancaria cuenta, double monto)
    {
        if (!estaOperativo)
        {
            Console.WriteLine("El cajero no está operativo.");
            return;
        }

        if (monto > efectivoDisponible)
        {
            Console.WriteLine("El cajero no tiene suficiente efectivo.");
            return;
        }

        if (monto > cuenta.saldo)
        {
            Console.WriteLine("Saldo insuficiente en la cuenta.");
            return;
        }

        cuenta.saldo -= monto;
        efectivoDisponible -= monto;
        Console.WriteLine($"Se retiraron ${monto} de la cuenta.");
        Console.WriteLine($"Nuevo saldo: ${cuenta.saldo}");
    }
}

public class CuentaBancaria 
{
    public string titular;          
    public string cbu;         
    public double saldo;                
    public string tipoCuenta;          
    public string banco;               
    public string dni;          

    public void Depositar(double monto) {
        saldo =+ monto;
        Console.WriteLine($"Depósito exitoso de ${monto}. Nuevo saldo: ${saldo}");
    } 
    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo disponible: ${saldo}");
    }
}


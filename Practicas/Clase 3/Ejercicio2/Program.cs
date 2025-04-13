// See https://aka.ms/new-console-template for more information
using System;

    class Program
    {
        static void Main(string[] args)
        {

        }  
    }

    public class Vehiculo {

        public string modelo;
        public string marca;
        public int añoFabricacion; 
        public string color;
        public float peso;
        public int capacidadPersonas;
        public string tipoCombustible;
        public int cantMotores;
        public bool pilotoAutomatico;
        public int numDeAsientos;

        public void Encender() {
            Console.WriteLine("El vehículo se ha encendido");
        }

        public void Detener() {
            Console.WriteLine("El vehículo se ha detenido");
        } 

        public void Frenar() {
            Console.WriteLine("El vehiculo ha activado el frenaje");
        }

        public void Acelarar() {
            Console.WriteLine("El vehiculo ha acelerado");
        }

        public void CargarCombustible() {
            Console.WriteLine("El vehículo está cargando combustible");
        }
    }

    public class VehiculoTerrestre : Vehiculo {
    public int cantDeRuedas;
    public string tipoTraccion;
    public string tipoChasis;
    public float tamañoLlantas;
    public string tipoSuspension;


    public void CambiarRuedas()  {}

    public void ActivarTraccion() {
        Console.WriteLine("Se ha activiado la tracción");
    }

    public void Estacionar() {
        Console.WriteLine("Se ha iniciado el proceso de estacionamiento");
        }
    }
      
    public class VehiculoAereo : Vehiculo {

        public float altitudMaximo;
        public float autonomiaDeVuelo;
        public string tipoAeronave;


        public void Despegar() {
            Console.WriteLine("El vehículo inicia su despegue");
        }

        public void Aterrizar() {
            Console.WriteLine("El vehículo comienza el aterrizaje");
        }

        public void EstabilizarVuelo() {
            Console.WriteLine("El vuelo comienza proceso de estabilización");
        }

    }

    public class VehiculoMaritimo : Vehiculo {

    public string tipoAncla;
    public int cantAnclas;
    public int cantCubiertas;
    public bool tieneRadarNautico;
    public bool tieneVelas;
    public string bandera;
    
    public void Zarpar() {
        Console.WriteLine("El vehículo empieza a zarpar");
    }  
    public void Atracar() {
        Console.WriteLine("Se comienza a atracar");
    }
    public void LanzarAncla() {
        Console.WriteLine("Se ha lanzando el ancla");
    }
    public void ActivarRadar() {
        Console.WriteLine("Ha activado el radar");
    }
    public void ApagarRadar() {
        Console.WriteLine("Ha apagado el radar");
    }
}


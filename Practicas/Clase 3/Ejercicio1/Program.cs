using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos un objeto de la clase colectivo (Que hereda atributos de la clase Vehículo)

            Autobus colectivo = new Autobus();
            colectivo.marca = "Mercedes-Benz";
            colectivo.modelo = "OH 1621";
            colectivo.añoFabricacion = 2020;
            colectivo.color = "Amarillo";
            colectivo.peso = 8500.0f;
            colectivo.capacidadPersonas = 45;
            colectivo.tipoCombustible = "Diesel";

            colectivo.cantDeRuedas = 6;
            colectivo.cantDePuertas = 2;
            colectivo.cantDeAsientos = 40;
            colectivo.idConductor = 1234;
            colectivo.ruta = "Línea 60 - Constitución ↔ Tigre";

            colectivo.MostrarInfo();
            colectivo.SubirPasajero();
            colectivo.BajarPasajero();
            colectivo.Encender();
            colectivo.Acelarar();
            colectivo.Frenar();
            colectivo.Detener();
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
    }

    public class Autobus : Vehiculo {
    public int cantDeRuedas;
    public int cantDePuertas;
    public int cantDeAsientos;
    public int idConductor;
    public string ruta;


    public void SubirPasajero()  {
        Console.WriteLine("El pasajero ha subido a bordo");
    }

    public void BajarPasajero() {
        Console.WriteLine("El pasajero ha bajado");
    }

    public void MostrarInfo() {

    Console.WriteLine("DATOS DEL AUTOBÚS:");
    Console.WriteLine($"Marca: {this.marca}");
    Console.WriteLine($"Modelo: {this.modelo}");
    Console.WriteLine($"Año de fabricación: {this.añoFabricacion}");
    Console.WriteLine($"Color: {this.color}");
    Console.WriteLine($"Peso: {this.peso} kg");
    Console.WriteLine($"Capacidad: {this.capacidadPersonas} personas");
    Console.WriteLine($"Tipo de combustible: {this.tipoCombustible}");
    Console.WriteLine($"Ruedas: {this.cantDeRuedas}");
    Console.WriteLine($"Puertas: {this.cantDePuertas}");
    Console.WriteLine($"Asientos: {this.cantDeAsientos}");
    Console.WriteLine($"ID Conductor: {this.idConductor}");
    Console.WriteLine($"Ruta: {this.ruta}");
    }
      
    
       
}

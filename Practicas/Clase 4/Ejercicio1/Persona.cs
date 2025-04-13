namespace Ejercicio1;

public class Persona
{
        public string nombre;
        private int edad;
        public string dni;

        public Persona () {
            this.nombre = "Carlos";
            this.edad = 38;
            this.dni = "40210321";
        }

        public Persona (string nombre) {
            this.nombre = nombre;
        }

        public Persona (string nombre, int edad, string dni)  {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        } 

        
        public int GetEdad() {
            return this.edad;
        }

        public void SetEdad(int edad) {
            this.edad = edad;
        } 

        public void MostrarDatos() {

            Console.WriteLine($"Datos de la persona --- Nombre: {this.nombre}, Edad: {this.GetEdad()}, Dni: {this.dni}");
            
        }
}
namespace sem7_ejercicio1 {

internal class Program
    {
    internal static void Main(string[] args)
        {
            Persona persona1 = new Persona("juan", "gonzales", "42000123", 20);
            Console.WriteLine(persona1.Presentarse());
            Alumno alumno1 = new Alumno("juan", "gonzales", "42000123", 20, "ifts 11");
            Console.WriteLine(alumno1.Presentarse());
        }
    }
}
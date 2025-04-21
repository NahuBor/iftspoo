public class Program{
        public static void Main(string[] args) {
        Persona persona1 = new Persona("juan","suarez",30,42542913,"M");
        Persona persona2 = new Persona("carlos","leviantuyax",25,42454321, "F");
        persona2.CompararEdad(persona1.edad);
        }
}

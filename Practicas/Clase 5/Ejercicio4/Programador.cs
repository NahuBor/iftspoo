public class Programador : DptoSistemas
{
    private string lenguaje;
    private string seniority;
    private int cantidadVecesProduccionCaida;

    public Programador(string nombre, string apellido, string telefono, string email, int dni, double sueldo,
                       string area, bool tieneTitulo, bool tieneComputadora, int genteACargo,
                       string lenguaje, string seniority, int caidas)
        : base(nombre, apellido, telefono, email, dni, sueldo, area, tieneTitulo, tieneComputadora, genteACargo)
    {
        this.lenguaje = lenguaje;
        this.seniority = seniority;
        this.cantidadVecesProduccionCaida = caidas;
    }
 public void MostrarInformacionEmpleado()
    {
        Console.WriteLine("Datos del empleado:");
        Console.WriteLine($"Nombre: {GetNombre()} {GetApellido()}");
        Console.WriteLine($"Teléfono: {GetTelefono()}");
        Console.WriteLine($"Email: {GetEmail()}");
        Console.WriteLine($"DNI: {GetDni()}");
        Console.WriteLine($"Sueldo: ${GetSueldo()}");
        Console.WriteLine($"Área donde se desarrolla: {GetArea()}");
        Console.WriteLine($"Título relacionado: {(GetTieneTituloRelacionado() ? "Sí" : "No")}");
        Console.WriteLine($"Computadora laboral: {(GetTieneComputadoraLaboral() ? "Sí" : "No")}");
        Console.WriteLine($"Personal a cargo: {GetCantidadGenteACargo()}");
        Console.WriteLine($"Lenguaje: {lenguaje}");
        Console.WriteLine($"Seniority: {seniority}");
        Console.WriteLine($"Veces que tumbó producción: {cantidadVecesProduccionCaida}");
    }
}


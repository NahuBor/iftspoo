public class DptoSistemas : Empleado
{
    private string area;
    private bool tieneTituloRelacionado;
    private bool tieneComputadoraLaboral;
    private int cantidadGenteACargo;

    public DptoSistemas(string nombre, string apellido, string telefono, string email, int dni, double sueldo,
                        string area, bool tieneTitulo, bool tieneComputadora, int genteACargo)
        : base(nombre, apellido, telefono, email, dni, sueldo)
    {
        this.area = area;
        this.tieneTituloRelacionado = tieneTitulo;
        this.tieneComputadoraLaboral = tieneComputadora;
        this.cantidadGenteACargo = genteACargo;
    }

    public string GetArea() {
        return area;
    }
    public bool GetTieneTituloRelacionado() {
        return tieneTituloRelacionado;
    }
    public bool GetTieneComputadoraLaboral() {
        return tieneComputadoraLaboral;
    }
    public int GetCantidadGenteACargo() {
        return cantidadGenteACargo;
    }
}

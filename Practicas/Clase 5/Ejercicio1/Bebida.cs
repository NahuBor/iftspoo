
public class Bebida : Producto
{

    public double volumenEnlitro;
    public bool esAlcoholica;
    public string tipoEnvase;
    public bool tieneGas;

    public Bebida(string nombre, int idProducto, string fechaVencimiento, double precio, int stock, string marca, double peso, bool necesitaRefrigeracion, double volumenEnlitro, bool esAlcoholica, string tipoEnvase, bool tieneGas) : base(nombre, idProducto, fechaVencimiento, precio, stock, marca, peso, necesitaRefrigeracion)
    {
        this.volumenEnlitro = volumenEnlitro;
        this.esAlcoholica = esAlcoholica;
        this.tipoEnvase = tipoEnvase;
        this.tieneGas = tieneGas;
    }

}
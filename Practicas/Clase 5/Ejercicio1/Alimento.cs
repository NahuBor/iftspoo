
public class Alimento : Producto
{
    public string tipoDeAlimento;

    public Alimento (string nombre, int idProducto, string fechaVencimiento, double precio, int stock, string marca, double peso, bool necesitaRefrigeracion, string tipoDeAlimento) : base(nombre, idProducto, fechaVencimiento, precio, stock, marca, peso, necesitaRefrigeracion)
    {
        this.tipoDeAlimento = tipoDeAlimento;
    }
}
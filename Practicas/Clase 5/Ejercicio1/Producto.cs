
public class Producto
{

    public string nombre;
    public int idProducto;
    public string fechaVencimiento;
    public double precio;
    public int stock;
    public string marca;
    public double peso;
    public bool necesitaRefrigeracion;

    public Producto (string nombre, int idProducto, string fechaVencimiento, double precio, int stock, string marca, double peso, bool necesitaRefrigeracion) {
        this.nombre = nombre;
        this.idProducto = idProducto;
        this.fechaVencimiento = fechaVencimiento;
        this.precio = precio;
        this.stock = stock;
    }

    public void VenderProducto(int cantidad) {
        if (cantidad >= 0 && cantidad <= stock) {
            stock -= cantidad;
            Console.WriteLine($"Venta realizada! Ha comprado {cantidad} unidades del producto {nombre}.");
        } else {
            Console.WriteLine("Stock insuficiente");
        }
    }
}
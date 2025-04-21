public class Program
{

    public static void Main(string[] args)
    {
    Bebida cocacola = new Bebida("Coca", 300, "04/01/2027", 1500, 20, "Coca Cola", 1.5, true, 1.5, true, "Botella de Plastico", true);

    Alimento harina = new Alimento("Harina", 301, "05/01/2027", 1000, 30, "XXX", 1.5, true, "Alimento que requiere preparación");

    cocacola.VenderProducto(10);
    harina.VenderProducto(20);
}

}

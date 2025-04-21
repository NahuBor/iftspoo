    public class Tren {
    public int velocidad;

    public Tren (int velocidad) {
        this.velocidad = velocidad;
    }

    public void Acelerar(int aceleracion) {
        this.velocidad += aceleracion;
        Console.WriteLine("El tren se acelera");
    }

    public void Frenar() {
        velocidad = 0;
        Console.WriteLine("El tren ha frenado");
        }
    }
using System;

    class Program
    {
        static void Main(string[] args)
        {

        }  
    }

    public class Libro {

    public string titulo;
    public string autor;
    public string editorial;
    public string año_publicacion;
    public string genero;
    public string idioma;
    public int califacion;
    public bool disponibilidad;

    public void AbrirLibro() {
        Console.WriteLine("El libro se ha abierto");
    }

    public void CerrarLibro() {
        Console.WriteLine("El libro se ha cerrado");
    }

    public void LeerLibro() {}

    public void EstaDisponible (bool disponibilidad) {
        if (disponibilidad == true) {
            Console.WriteLine("El libro está disponible");
        } else {Console.WriteLine("El libro no esta disponible");}
    }

    public void MostrarDatos() {
        Console.WriteLine($"Datos del libro:");
        Console.WriteLine($"Titulo: {this.titulo}");
        Console.WriteLine($"Autor: {this.autor}");
        Console.WriteLine($"Editorial: {this.editorial}");
        Console.WriteLine($"Año de publicación: {this.año_publicacion}");
        Console.WriteLine($"Genero: {this.genero}");
        Console.WriteLine($"Idioma: {this.idioma}");
        Console.WriteLine($"Calificacion: {this.califacion}");
        Console.WriteLine($"Disponibilidad: {this.disponibilidad}");
    }    

    }

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic; 


    class Program
    {
        static void Main(string[] args)
        {

        Biblioteca biblioteca = new Biblioteca();
        biblioteca.nombre = "Jose Ñandu";
        biblioteca.direccion = "Av. Lo que pinta 742";
        biblioteca.horarioApertura = "08:00";
        biblioteca.horarioCierre = "20:00";
        biblioteca.telefono = "1234-5678";
        biblioteca.correo = "contacto@bibliotecaantigua.com";
        biblioteca.capacidadMaxima = 100;

        // Crear libros
        Libro libro1 = new Libro();
        libro1.titulo = "Cien Años de Soledad";
        libro1.autor = "Gabriel García Márquez";
        libro1.editorial = "Panini";
        libro1.año_publicacion = "1967";
        libro1.genero = "Realismo Mágico";
        libro1.idioma = "Español";
        libro1.califacion = 10;
        libro1.disponibilidad = true;

        Libro libro2 = new Libro();
        libro2.titulo = "1984";
        libro2.autor = "George Orwell";
        libro2.editorial = "Secker & Warburg";
        libro2.año_publicacion = "1949";
        libro2.genero = "Distopía";
        libro2.idioma = "Inglés";
        libro2.califacion = 9;
        libro2.disponibilidad = false;

        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        biblioteca.MostrarHorario(biblioteca.horarioApertura, biblioteca.horarioCierre);
        Console.WriteLine();

        biblioteca.ListarLibros();

        Console.WriteLine();
        libro1.MostrarDatos();
        libro1.AbrirLibro();
        libro1.CerrarLibro();
        libro1.EstaDisponible(libro1.disponibilidad);
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

    public class Biblioteca {

    public string nombre;
    public string direccion;
    public string horarioApertura;
    public string horarioCierre;
    public string telefono;
    public string correo;
    public int capacidadMaxima;

    public List<Libro> Libros = new List<Libro>();

    public void AgregarLibro(Libro libro) {
        Libros.Add(libro);
    }

    public void RemoverLibro(Libro libro) {
        Libros.Remove(libro);
    }

    public void MostrarHorario(string horarioApertura, string horarioCierre) {
        Console.WriteLine($"El horario de apertura es: {horarioApertura} y cerramos a las: {horarioCierre}.");
    }

    public void ListarLibros () {
        Console.WriteLine("Libros Disponibles:");
        foreach (var libro in Libros) {
        Console.WriteLine($"Título: {libro.titulo}");
        Console.WriteLine($"Autor: {libro.autor}");
        Console.WriteLine($"Editorial: {libro.editorial}");
        Console.WriteLine($"Año de Publicación: {libro.año_publicacion}");
        Console.WriteLine($"Género: {libro.genero}");
        Console.WriteLine($"Idioma: {libro.idioma}");
        Console.WriteLine($"Calificación: {libro.califacion}/10");
        Console.WriteLine($"Disponibilidad: {libro.disponibilidad}");
        Console.WriteLine("-----------------------------");
        };
    }



    }
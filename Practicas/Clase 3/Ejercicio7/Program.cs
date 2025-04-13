using System;

    class Program
    {
        static void Main(string[] args)
        {

        Rol Ingeniero = new Rol("Ingeniero", 0.10);
        Rol AyudanteDeObra = new Rol("Ayudante de Obra", 0.5);

        Empleado empleado1 = new Empleado("Lucas", "Goliat", "40123456", 100000);
        Empleado empleado2 = new Empleado("Susana",  "Gimenez", "40111222", 95000);

        Departamento ObraPublica = new Departamento("Sistemas");

        ObraPublica.AgregarEmpleado(empleado1);
        ObraPublica.AgregarEmpleado(empleado2);

        ObraPublica.AsignarRol(empleado1, Ingeniero);
        ObraPublica.AsignarRol(empleado2, AyudanteDeObra);

        empleado1.MostrarDatos();
        empleado2.MostrarDatos();


        }  
    }

    public class Rol  {
    public string rol;
    public double bonificacion;

    public Rol(string rolAPoner, double bonificacion)
    {
        this.rol = rolAPoner;
        this.bonificacion = bonificacion;
    }
}


public class Empleado {
    public string nombre;
    public string apellido;
    public string dni;
    public double salarioBase;
    public Rol rol;

    public Empleado(string nombre, string apellido, string dni, double salarioBase)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
        this.salarioBase = salarioBase;
    }

      public void MostrarDatos() {
        Console.WriteLine($"Empleado: {nombre}, Apellido {apellido} DNI: {dni}");
        Console.WriteLine($"Salario base: ${salarioBase}");
        Console.WriteLine($"Rol: {rol.rol} | Bonificación: {rol.bonificacion * 100}%");
    }

    public double CalcularSalarioConBonificacion()
    {
     return salarioBase + (salarioBase * rol.bonificacion);
    }

}

public class Departamento
{
    public string nombre;
    public List<Empleado> empleados = new List<Empleado>(); // Creamos una lista de objetos tipo Empleado.

    public Departamento(string nombre)
    {
        this.nombre = nombre;
    }

    public void AgregarEmpleado(Empleado empleadoAAgregar)
    {
        empleados.Add(empleadoAAgregar);
        Console.WriteLine($"Empleado {empleadoAAgregar.nombre} agregado al departamento {nombre}.");
    }

    
    public void AsignarRol(Empleado empleadoAAsignarRol, Rol rolAAsignar)
    {
        empleadoAAsignarRol.rol = rolAAsignar;
        Console.WriteLine($"Rol '{rolAAsignar.rol}' asignado a {empleadoAAsignarRol.nombre} en el departamento {nombre}.");
    }
}



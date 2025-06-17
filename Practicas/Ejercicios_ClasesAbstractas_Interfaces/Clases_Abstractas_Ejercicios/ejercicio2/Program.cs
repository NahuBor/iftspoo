namespace CAbstractas.ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        EmployeeFullTime empFull = new EmployeeFullTime ("javi", 50000);
        EmployeePartTime empPart = new EmployeePartTime ("nahuel", 50000, 25);
        EmployeePartTime empPart2 = new EmployeePartTime ("carlos", 50000, 10);
        empFull.ComputeSalary();
        empPart.ComputeSalary();
        empPart2.ComputeSalary();
    }
}

namespace CAbstractas.ejercicio2 {
    public class EmployeeFullTime : Employee {
        public double presenteeismBonus = 20;

       public EmployeeFullTime(string name, double baseSalary) :base(name, baseSalary) {
            
        }

        public override void ComputeSalary () {
            Console.WriteLine($"El sueldo de {name} de modalidad full time es: {baseSalary + (baseSalary * presenteeismBonus / 100) }");
        }

    }
}
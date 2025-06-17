namespace CAbstractas.ejercicio2 {
    public class EmployeePartTime : Employee {
        public double extraBonus = 15;
        public double extraHours;

        public EmployeePartTime (string name, double baseSalary, double extraHours) :base (name, baseSalary) {

            this.extraHours = extraHours;

        }

        public override void ComputeSalary()
        {
            if (extraHours !> 20) {
                Console.WriteLine($"El sueldo de {name} de modalidad part time es: {baseSalary}");
            } else {
            Console.WriteLine($"El sueldo de {name} de modalidad part time y con extra es: {baseSalary + (baseSalary * extraBonus / 100)}");
            }
        }  
    }
}
namespace CAbstractas.ejercicio2 {
    public abstract class Employee {
        public string name;
        public double baseSalary;

        public Employee (string name, double baseSalary) {
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public abstract void ComputeSalary();

    }
}
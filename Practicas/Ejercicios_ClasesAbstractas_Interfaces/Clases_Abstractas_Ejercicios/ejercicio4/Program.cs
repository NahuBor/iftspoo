namespace CAbstractas.ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Dog();
        animals[1] = new Cat();
        animals[2] = new Snake();
        foreach (Animal a in animals) {
            a.MostrarInfo();
            a.AnimalSound();
            Console.WriteLine();
        }
    }
}

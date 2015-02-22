using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        foreach (Animal a in animals)
        {
            Console.WriteLine(a.MakeNoise());
            a.Sleep();
        }
    }
}
public class Animal
{
    public virtual string MakeNoise() { return String.Empty; }
    public void Sleep()
    {
        Console.WriteLine(this.GetType().ToString() + " is sleeping.");
    }
}
public class Dog : Animal
{
    public override string MakeNoise()
    {
        return "Woof!";
    }
}
public class Cat : Animal
{
    public override string MakeNoise()
    {
        return "Meow!";
    }
}
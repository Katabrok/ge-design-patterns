using System;

namespace ge_designer_patterns_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get a new car");

            var fiesta = new Fiesta();

            Console.WriteLine(string.Format("I'm a {0} car made by {2} and {1}", fiesta.GetType().ToString(), fiesta.Speed(), fiesta.Brand()));
            Console.WriteLine("My decorator behavior is a boost value: " + fiesta.Boost().ToString());

            var ferrari = new Ferrari458();

            Console.WriteLine();
            Console.WriteLine(string.Format("I'm a {0} car made by {2} and {1}", ferrari.GetType().ToString(), ferrari.Speed(), ferrari.Brand()));
            Console.WriteLine("My decorator behavior is a Fuel consumption value: " + ferrari.ConsumePerLitre(true).ToString());

            var car = new Carro();

            Console.WriteLine();
            Console.WriteLine(string.Format("I'm a {0} car made by {2} and {1}", car.GetType().ToString(), car.Speed(), car.Brand()));
            Console.WriteLine("My decorator behavior is none");

            Console.ReadLine();
        }
    }
}
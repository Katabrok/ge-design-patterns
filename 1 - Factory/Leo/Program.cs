using System;
using Factory.Models;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{GetCar()}");
            Console.WriteLine($"{CarFactory.GetCarOfTheYear()}");
            Console.WriteLine($"{CarFactory.GetSpecificCar("Lambo")}");
            Console.WriteLine($"{CarFactory.GetSpecificCar("Vantage")}");
            Console.WriteLine($"{CarFactory.GetSpecificCar("Fiat 147")}");


        }

        static Carro GetCar()
        {
            var ferrari= new Carro
            {
                Nome = "Ferrari F40",
                Motorizacao = "V8 4.0",
                AnoModelo = 1995,
                VelocidadeMaxima = 100,
                Preco = 10_000_000,
            };

            return ferrari;
        }
    }
}

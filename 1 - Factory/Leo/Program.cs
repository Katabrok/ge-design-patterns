using System;
using Factory.Models;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{GetModelOfTheYearV1()}");
        }

        static Carro GetModelOfTheYearV1()
        {
            var ferrari= new Carro
            {
                Nome = "Ferrari F40",
                Motorizacao = "Ferrari V8 4.0",
                AnoModelo = 1995,
                VelocidadeMaxima = 100,
                Preco = 10_000_000,
            };

            return ferrari;
        }
    }
}

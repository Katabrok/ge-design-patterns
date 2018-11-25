using System;

namespace NoPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaMussarela pizzaMussarela = new PizzaMussarela();
            pizzaMussarela.Make();
            Console.WriteLine();

            PizzaCalabresa pizzaCalabresa = new PizzaCalabresa();
            pizzaCalabresa.Make();
            Console.WriteLine();

            PizzaFrango pizzaFrango = new PizzaFrango();
            pizzaFrango.Make();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

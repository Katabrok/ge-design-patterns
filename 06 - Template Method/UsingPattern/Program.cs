using System;

namespace UsingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaMussarela pizzaDeMussarela = new PizzaMussarela();
            pizzaDeMussarela.Make();

            PizzaCalabresa pizzaCalabresa = new PizzaCalabresa();
            pizzaCalabresa.Make();

            PizzaFrango pizzaFrango = new PizzaFrango();
            pizzaFrango.Make();
              

            Console.ReadKey();
        }
    }
}

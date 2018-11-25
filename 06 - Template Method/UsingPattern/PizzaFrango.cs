using System;
using System.Collections.Generic;
using System.Text;

namespace UsingPattern
{
    public class PizzaFrango : Pizza
    {
        public override string PizzaSelected { get; set; }
        public override string Ingredients { get; set; }

        public PizzaFrango()
        {
            Ingredients = "Ingredientes: 300g de frango desfiado, e algumas azeitonas";
            PizzaSelected = "Frango";
        }

        public override void Bake()
        {
            Console.WriteLine($"Assando a pizza {PizzaSelected} em forno alto.");
        }

        public override void SelectIngredients()
        {
            Console.WriteLine($"{Ingredients}");
        }
    }
}

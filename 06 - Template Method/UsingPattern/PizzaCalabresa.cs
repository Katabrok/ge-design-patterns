using System;
using System.Collections.Generic;
using System.Text;

namespace UsingPattern
{
    public class PizzaCalabresa : Pizza
    {
        public override string PizzaSelected { get; set; }
        public override string Ingredients { get; set; }

        public PizzaCalabresa()
        {
            Ingredients = "Ingredientes: 300g de calabresa fatiada, 50g de cebola em rodelas, azeitonas";
            PizzaSelected = "Calabresa";
        }

        public override void Bake()
        {
            Console.WriteLine($"Assando a pizza {PizzaSelected} em forno médio.");
        }

        public override void SelectIngredients()
        {
            Console.WriteLine($"{Ingredients}");
        }
    }
}
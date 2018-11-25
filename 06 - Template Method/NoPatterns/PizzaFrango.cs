using System;
using System.Collections.Generic;
using System.Text;

namespace NoPatterns
{
    public class PizzaFrango
    {
        public string Ingredients { get; set; }
        public string PizzaSelected { get; set; }

        public PizzaFrango()
        {
            Ingredients = "300g de frango desfiado, e algumas azeitonas";
            PizzaSelected = "Frango";
        }

        public void Init()
        {
            Console.WriteLine($"Fazendo Pizza de {PizzaSelected}:");
        }

        public void SelectIngredients()
        {
            Console.WriteLine($"{Ingredients}");
        }

        public void Duration()
        {
            Console.WriteLine("Tempo de duração: 20min.");
        }

        public void Bake()
        {
            Console.WriteLine($"Assando a pizza {PizzaSelected} em forno baixo.");
        }

        public void Make()
        {
            Init();
            SelectIngredients();
            Duration();
            Bake();
            Console.WriteLine($"A Pizza de {PizzaSelected} esta pronta.");
        }
    }
}

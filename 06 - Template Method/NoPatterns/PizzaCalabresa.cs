using System;
using System.Collections.Generic;
using System.Text;

namespace NoPatterns
{
    public class PizzaCalabresa
    {
        public string Ingredientes { get; set; }
        public string PizzaSelected { get; set; }

        public PizzaCalabresa()
        {
            Ingredientes = "Ingredientes: 300g de calabresa fatiada, 50g de cebola em rodelas, azeitonas";
            PizzaSelected = "Calabresa";
        }

        public void Init()
        {
            Console.WriteLine($"Pizza de {PizzaSelected}:");
        }

        public void SelectIngredients()
        {
            Console.WriteLine($"{Ingredientes}");
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

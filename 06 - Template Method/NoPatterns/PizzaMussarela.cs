using System;

namespace NoPatterns
{
    public class PizzaMussarela
    {
        public string itensDaPizza { get; set; }
        public string pizzaSelecionada { get; set; }

        public PizzaMussarela()
        {
            itensDaPizza = $"300g de mussarela, 8 fatias de tomate, oregano, e azeitonas.";
            pizzaSelecionada = "Pizza de mussarela";
        }

        public void Init()
        {
            Console.WriteLine($"Vamos fazer pizza de {pizzaSelecionada}:");
        }

        public void SelectIngredients()
        {
            Console.WriteLine($"{itensDaPizza}");
        }
       
        public void Duration()
        {
            Console.WriteLine("duração: 20min.");
        }

        public void Bake()
        {
            Console.WriteLine($"Assando a pizza {pizzaSelecionada} em forno baixo.");
        }

        public void Make()
        {
            Init();
            SelectIngredients();
            Duration();
            Bake();
            Console.WriteLine($"A Pizza de {pizzaSelecionada} esta pronta.");
        }
    }
}
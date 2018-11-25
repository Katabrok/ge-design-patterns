using System;

namespace UsingPattern
{
    /// <summary>
    /// Representação da classe Concret no diagrama
    /// </summary>
    public class PizzaMussarela : Pizza
    {
        public override string Ingredients { get; set; }
        public override string PizzaSelected { get; set; }

        public PizzaMussarela()
        {
            Ingredients = $"Ingredientes: 300g de mussarela, 8 fatias de tomate, oregano, e azeitonas.";
            PizzaSelected = "Mussarela";
        }

        public override void SelectIngredients()
        {
            Console.WriteLine($"{Ingredients}");
        }

        //public override void Slice()
        //{
        //    base.Slice();
        //    Console.WriteLine("Embalar a pizza depois de fatiar.");
        //}
       
        public override void Bake()
        {
            Console.WriteLine($"Assando a pizza {PizzaSelected} em forno baixo.");
        }
    }
}
using System;

namespace UsingPattern
{
    /// <summary>
    /// Representação de Abstract class no diagrama
    /// </summary>
    public abstract class Pizza
    {
        #region Primitive        
        public abstract string PizzaSelected { get; set; }
        public abstract string Ingredients { get; set; }
        public abstract void SelectIngredients();
        public abstract void Bake();

        public virtual void Init()
        {
            Console.WriteLine($"Pizza de {PizzaSelected}:");
        }
        public virtual void Slice()
        {
            Console.WriteLine($"Fatiando a pizza de { PizzaSelected } em 8 partes.");
        }
        public virtual void Duration()
        {
            Console.WriteLine("Tempo de preparo: 20min");
        }
        #endregion

        #region template
        public void Make()
        {
            Init();
            SelectIngredients();
            Bake();
            Duration();
            Slice();
            Console.WriteLine($"A Pizza de {PizzaSelected} esta pronta.");
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
    }
}
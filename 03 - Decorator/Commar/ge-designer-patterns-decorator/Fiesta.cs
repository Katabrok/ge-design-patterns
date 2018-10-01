using System;
namespace ge_designer_patterns_decorator
{
    public class Fiesta : Carro, ICarro
    {
        public Fiesta()
        {
        }

        public new string Speed()
        {
            return "My fasted speed can be 200 km/h";
        }

        /// <summary>
        /// Boost Fiesta this is a new behivor
        /// </summary>
        /// <returns>The boost.</returns>
        public Double Boost()
        {
            return 200 * 1.1;
        }

        public new string Brand()
        {
            return "Ford";
        }
    }
}

using System;
namespace ge_designer_patterns_decorator
{
    public class Carro : ICarro
    {
        public Carro()
        {
        }

        public string Brand()
        {
            return "Generic car";
        }

        public string Speed()
        {
            return "My fasted speed can be 120 km/h";
        }
    }
}

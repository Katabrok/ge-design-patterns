using System;
namespace ge_designer_patterns_decorator
{
    public sealed class Carro : ICarroExterno
    {
        public string Brand { get; set; }
        public double Speed { get; set; }

        public Carro()
        {
            Brand = "MArca";
            Speed = 120;
        }

        public static Carro getCarro()
        {
            return new Carro() { Speed = 220, Brand = "fiat 147" };
        }

        //public string Brand()
        //{
        //    return "Generic car";
        //}

        //public string Speed()
        //{
        //    return "My fasted speed can be 120 km/h";
        //}
    }

    public interface ICarroExterno
    {
        string Brand { get; set; }
        double Speed { get; set; }
    }
}

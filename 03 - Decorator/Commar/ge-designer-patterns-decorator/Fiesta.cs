using System;
namespace ge_designer_patterns_decorator
{
    public class Fiesta : ICarroExterno
    {
        private Carro _myCar;

        public Fiesta()
        {
            _myCar = new Carro();
            _myCar.Brand = "Ford";
        }

        public string Brand { get => _myCar.Brand; set => _myCar.Brand = value; }
        public double Speed { get => _myCar.Speed; set => _myCar.Speed = value; }

        //public new string Speed()
        //{
        //    return "My fasted speed can be 200 km/h";
        //}

        ///// <summary>
        ///// Boost Fiesta this is a new behivor
        ///// </summary>
        ///// <returns>The boost.</returns>
        //public Double Boost()
        //{
        //    return 200 * 1.1;
        //}

        //public new string Brand()
        //{
        //    return "Ford";
        //}
    }
}

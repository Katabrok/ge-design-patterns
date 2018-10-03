namespace ge_designer_patterns_decorator
{
    internal class Ferrari458 : ICarroExterno
    {
        private Carro _myCar;

        public Ferrari458()
        {
            _myCar = new Carro();
            _myCar.Brand = "Ferrari";
        }

        public Ferrari458(Carro car)
        {
            _myCar = car;
        }

        public string Brand { get => _myCar.Brand; set => _myCar.Brand = value; }
        public double Speed { get => _myCar.Speed; set => _myCar.Speed = value; }

        public void Boost()
        {
            _myCar.Speed = _myCar.Speed * 1.5;
        }
    }
}
using Factory.Models;

namespace Factory
{
    public static class CarFactory
    {
        public static Carro GetCarOfTheYear()
        {
            return new FerrariF40();
        }

        public static Carro GetSpecificCar(string model)
        {
            switch (model)
            {
                case "Ferrari":
                    return new FerrariF40();
                case "Lambo":
                    return new LamborghiniDiablo();
                case "Aston":
                case "Vantage":
                    return new AstonMartinVantage();
            }

            return new Carro
            {
                Nome = "Fusca",
                Motorizacao = "1.6L Boxer 4",
                AnoModelo = 1977,
                VelocidadeMaxima = 130,
                Preco = 4_500,
            };
        }
    }
}
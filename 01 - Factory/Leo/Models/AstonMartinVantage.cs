namespace Factory.Models
{
    public class AstonMartinVantage: Carro
    {
        public AstonMartinVantage()
        {
            this.Nome = "Aston Martin Vantage";
            this.AnoModelo = 2018;
            this.Motorizacao = "4.0-litre twin-turbo V8";
            this.VelocidadeMaxima = 314;
            this.Preco = 8_500_000;
        }
    }
}
namespace Factory.Models
{
    public class LamborghiniDiablo : Carro
    {
        public LamborghiniDiablo()
        {
            this.Nome = "Lamborghini Diablo";
            this.AnoModelo = 1990;
            this.Motorizacao = "6.0L V12";
            this.VelocidadeMaxima = 335;
            this.Preco = 12_000_000;
        }
    }
}
namespace Factory.Models
{
    public class FerrariF40 : Carro
    {
        public FerrariF40()
        {
            this.Nome = "Ferrari F40";
            this.AnoModelo = 1987;
            this.Motorizacao = "2.9L V8 BiTurbo";
            this.VelocidadeMaxima = 321;
            this.Preco = 10_000_000;
        }
    }
}
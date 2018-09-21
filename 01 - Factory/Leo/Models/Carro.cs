namespace Factory.Models
{
    public class Carro
    {
        public Carro()
        {
        }

        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public int VelocidadeMaxima { get; set; }
        public decimal Preco { get; set; }
        public int AnoModelo { get; set; }

        public override string ToString() => $"Nome: {this.Nome} - Motorização: {this.Motorizacao} - Velocidade Maxima: {this.VelocidadeMaxima} km/h - Ano: {this.AnoModelo} - Preço: R$ {this.Preco:0,000.00}";
    }
}
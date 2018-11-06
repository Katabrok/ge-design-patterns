namespace Iterator
{
    // Minha coleção de Itens (nesse caso: canais)
    class Canal
    {
        public string _nome;
        
        // Construtor
        public Canal(string nome)
        {
            this._nome = nome;
        }

        // Recupera o nome
        public string Nome
        {
            get { return _nome; }
        }
    }
}

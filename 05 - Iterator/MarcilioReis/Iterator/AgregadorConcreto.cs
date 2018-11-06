using System.Collections;

namespace Iterator
{
    /// <summary>
    /// Implementa a interface de criação do agregador - Retorna uma instancia adequada do Iterador Concreto
    /// </summary>
    class AgregadorConcreto : IAgregador
    {
        private ArrayList _items = new ArrayList();

        public IteradorConcreto CriarIterator()
        {
            return new IteradorConcreto(this);
        }

        // Obtém contagem de itens
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexador
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}

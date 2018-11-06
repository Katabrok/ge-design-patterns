using System.Collections;

namespace Iterator
{
    /// <summary>
    /// Implementa a interface do iterador - Mantém o controle da posição atual na travessia do agregador.
    /// </summary>
    class IteradorConcretoCSharp : IEnumerator
    {
        private AgregadorConcreto _collection;
        private int _current = 0;
        private int _step = 1;

        // Construtor
        public IteradorConcretoCSharp(AgregadorConcreto collection)
        {
            this._collection = collection;
            Reset();
        }

        // Recupera primeiro item
        public Canal Primeiro()
        {
            _current = 0;
            return _collection[_current] as Canal;
        }

        // Recupera próximo item
        public Canal Proximo()
        {
            _current += _step;
            if (!Completo)
                return _collection[_current] as Canal;
            else
                return null;
        }

        public bool MoveNext()
        {
            _current += _step;

            return !Completo;
        }

        public void Reset()
        {
            _current = -1;
        }

        // Verifica em qual passo estamos
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Recupera item atual
        public Canal ItemAtual
        {
            get { return _collection[_current] as Canal; }
        }

        // Recupera se iteração estiver completa
        public bool Completo
        {
            get { return _current >= _collection.Count; }
        }

        public object Current => _collection[_current] as Canal;
    }
}

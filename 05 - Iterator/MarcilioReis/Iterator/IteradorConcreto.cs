using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class IteradorConcreto : IteradorInterface
    {
        private AgregadorConcreto _collection;
        private int _current = 0;
        private int _step = 1;

        // Construtor
        public IteradorConcreto(AgregadorConcreto collection)
        {
            this._collection = collection;
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
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class Canais : IEnumerable
    {
        private AgregadorConcreto _agregador;

        public Canais(AgregadorConcreto agregador)
        {
            _agregador = agregador;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new IteradorConcretoCSharp(_agregador);
        }
    }
}

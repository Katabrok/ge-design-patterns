namespace Iterator
{    
    //Concrete Interator
    public class ConcreteIterator : IIteratorPattern
    {
        private ConcreteAggregate Collection;
        private int position;
        public ConcreteIterator(ConcreteAggregate collection)
        {
            this.Collection = collection;
            position = 0;
        }

        public object CurrentPosition()
        {
            return Collection[position - 1];
        }

        public object First()
        {
            return Collection[0];
        }

        public object Next()
        {
            if (IsDone()) return null;
            object obj = Collection[position];
            position++;
            return obj;
        }

        public bool IsDone()
        {
            return position >= Collection.Count;
        }
    }
}
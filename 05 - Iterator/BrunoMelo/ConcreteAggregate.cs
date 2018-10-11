using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList item = new ArrayList();

        public int Count { get { return item.Count; } }

        public object this[int index]
        {
            get { return item[index]; }
        }

        public void Add(object value)
        {
            item.Add(value);
        }
     
        public ConcreteIterator CreateInterato()
        {
            return new ConcreteIterator(this);
        }
    }
}
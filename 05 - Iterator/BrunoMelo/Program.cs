using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ConcreteAggregate();

            for (int i = 0; i < 10; i++)
                collection.Add($" 1 + {i} = {i + 1}");

            var iterator = new ConcreteIterator(collection);

            while (!iterator.IsDone())
                Console.WriteLine(iterator.Next());
            
            Console.WriteLine($"\n Valor da primeira posição: {iterator.First()} \n");
            Console.WriteLine($" Valor da ultima posição: {iterator.CurrentPosition()}");
            Console.ReadKey();
        }
    }
}

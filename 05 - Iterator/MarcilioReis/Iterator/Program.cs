using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregadorConcreto collection = new AgregadorConcreto();

            collection[0] = new Canal("Item 0");
            collection[1] = new Canal("Item 1");
            collection[2] = new Canal("Item 2");
            collection[3] = new Canal("Item 3");
            collection[4] = new Canal("Item 4");
            collection[5] = new Canal("Item 5");
            collection[6] = new Canal("Item 6");
            collection[7] = new Canal("Item 7");
            collection[8] = new Canal("Item 8");

            // Cria o iterador
            IteradorConcreto iterator = collection.CriarIterator();

            // Pula sempre um item
            iterator.Step = 2;

            Console.WriteLine("Iterando pela coleção");

            for (Canal item = iterator.Primeiro();
                !iterator.Completo; item = iterator.Proximo())
            {
                Console.WriteLine(item.Nome);
            }

            // Aguarda
            Console.ReadKey();
        }
    }
}

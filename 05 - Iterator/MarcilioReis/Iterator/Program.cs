using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregadorConcreto collection = new AgregadorConcreto();

            collection[0] = new Canal("BBC");
            collection[1] = new Canal("Deutsche Welle");
            collection[2] = new Canal("Al Jazeera");
            collection[3] = new Canal("CNN");
            collection[4] = new Canal("Globonews");
            collection[5] = new Canal("NHK");
            collection[6] = new Canal("Bloomberg");
            collection[7] = new Canal("TVE");
            collection[8] = new Canal("Rai");

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

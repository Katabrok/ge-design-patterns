namespace Iterator
{
    interface IteradorInterface
    {
        Canal Primeiro();
        Canal Proximo();
        bool Completo { get; }
        Canal ItemAtual { get; }
    }
}

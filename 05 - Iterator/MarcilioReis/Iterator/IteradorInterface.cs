namespace Iterator
{
    /// <summary>
    /// Interface do iterador - Define uma interface para acessar e percorrer os elementos
    /// </summary>
    interface IteradorInterface
    {
        Canal Primeiro();
        Canal Proximo();
        bool Completo { get; }
        Canal ItemAtual { get; }
    }
}

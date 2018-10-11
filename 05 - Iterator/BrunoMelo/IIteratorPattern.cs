namespace Iterator
{   
    public interface IIteratorPattern
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentPosition();
    }
}
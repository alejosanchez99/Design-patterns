namespace Iterator.Example1
{
    public interface ICollection<T>
    {
        IIterator<T> CreateIterator();
    }
}

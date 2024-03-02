namespace Iterator.Example1
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}

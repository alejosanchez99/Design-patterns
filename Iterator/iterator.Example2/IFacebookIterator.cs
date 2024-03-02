namespace Iterator.Example2
{
    public interface IFacebookIterator
    {
        User CurrentUser();
        bool HasNextUser();
        User NextUser();
    }
}

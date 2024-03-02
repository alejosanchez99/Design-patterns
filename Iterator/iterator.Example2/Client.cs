namespace Iterator.Example2
{
    using System;

    public class Client
    {
        public void ShowUsers(ICollection collection)
        {
            IFacebookIterator iterator = collection.CreateIterator();
            while (iterator.HasNextUser())
            {
                User user = iterator.NextUser();
                Console.WriteLine(user.Name);
            }
        }
    }
}

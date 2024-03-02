namespace Iterator.Example2
{
    using System.Collections.Generic;

    public class UserCollection : ICollection
    {
        private readonly List<User> users;

        public UserCollection(List<User> users)
        {
            this.users = users;
        }

        public IFacebookIterator CreateIterator()
        {
            return new FacebookIterator(this.users);
        }
    }
}

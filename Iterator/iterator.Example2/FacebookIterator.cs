namespace Iterator.Example2
{
    using System;
    using System.Collections.Generic;

    public class FacebookIterator : IFacebookIterator
    {
        private readonly List<User> users;
        private int position = -1;

        public FacebookIterator(List<User> users)
        {
            this.users = users;
        }

        public User CurrentUser()
        {
            if (this.position < 0 || this.position >= this.users.Count)
            {
                throw new InvalidOperationException();
            }

            return this.users[this.position];
        }

        public bool HasNextUser()
        {
            return this.position + 1 < this.users.Count;
        }

        public User NextUser()
        {
            if (!this.HasNextUser())
            {
                throw new InvalidOperationException();
            }

            this.position++;

            return this.users[this.position];
        }
    }
}

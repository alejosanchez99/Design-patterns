namespace Singleton2
{
    using System;

    public class MySingleton
    {
        private static MySingleton instance;

        public Guid Id { get; private set; }
        private MySingleton()
        {
            this.Id = Guid.NewGuid();
        }

        public static MySingleton GetInstance()
        {
            instance ??= new MySingleton();

            return instance;
        }
    }
}

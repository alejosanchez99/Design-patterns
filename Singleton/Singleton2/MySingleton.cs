namespace Singleton2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MySingleton
    {
        private static MySingleton instance;

        public Guid Id { get; private set; }
        private MySingleton()
        {
            Id = Guid.NewGuid();
        }

        public static MySingleton GetInstance()
        {
            instance ??= new MySingleton();

            return instance;
        }
    }
}

namespace Singleton
{
    public class MySingleton
    {
        private static MySingleton instance;

        private MySingleton()
        {

        }

        public static MySingleton GetInstance()
        {
            instance ??= new MySingleton();

            return instance;
        }
    }
}

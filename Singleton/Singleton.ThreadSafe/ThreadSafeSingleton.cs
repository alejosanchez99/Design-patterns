namespace Singleton.ThreadSafe
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? instance;

        private static readonly object _lock = new object();

        private ThreadSafeSingleton()
        {

        }

        /// <summary>
        /// Esto de encarga de validar la creación de instancia cuando se trabaja con multi hilos.
        /// </summary>
        /// <returns></returns>
        public static ThreadSafeSingleton GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    instance ??= new ThreadSafeSingleton();
                }
            }

            return instance;
        }
    }
}

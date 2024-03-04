namespace Observer.Example1
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}

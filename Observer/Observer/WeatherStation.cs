namespace Observer.Example1
{
    using System.Collections.Generic;

    public class WeatherStation : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private readonly List<IObserver> observers = new List<IObserver>(0);


        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            this.NotifyObserve();
        }

        public void NotifyObserve()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}

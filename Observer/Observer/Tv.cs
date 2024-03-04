namespace Observer.Example1
{
    using System;

    public class Tv : IObserver
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {this.temperature}F degrees and {this.humidity}% humidity and pressure {this.pressure}");
        }
    }
}

using Observer.Example1;

WeatherStation weatherStation = new WeatherStation();
Tv currentDisplay = new Tv();

weatherStation.RegisterObserver(currentDisplay);

weatherStation.SetMeasurements(80, 64, 30.4f);

weatherStation.SetMeasurements(82, 70, 29.2f);

weatherStation.SetMeasurements(78, 90, 29.2f);

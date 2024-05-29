using ObserverPatternWeatherMonitoring.Observer;
using ObserverPatternWeatherMonitoring.Subject;

WeatherStation weatherStation = new WeatherStation();
CurrentWeather currentWeather = new CurrentWeather();
Forecast forecast = new Forecast();

weatherStation.RegisterObserver(currentWeather);
weatherStation.RegisterObserver(forecast);

weatherStation.SetWeatherData(25, 60, 1013);
weatherStation.SetWeatherData(27, 55, 1012);


Console.ReadKey();

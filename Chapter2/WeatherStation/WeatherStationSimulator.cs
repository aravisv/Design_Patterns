using WeatherStation;
using WeatherStation.Interfaces;
using WeatherDisplay;
public class WeatherStationSimulator
{
    static void Main()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentWeather = new CurrentConditionsDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
        weatherData.SetMeasurements(10.10f, 20.20f, 30.30f);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherForcast
{
    public class DataStorage
    {
        private List<WeatherForecast> _forecasts;

        public DataStorage()
        {
            _forecasts = new List<WeatherForecast>();
            SetupInitialValues();
        }

        public DataStorage(List<WeatherForecast> forecasts)
        {
            _forecasts = forecasts;
        }

        public WeatherForecast AddTemperaturAtDate(int temperature, string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            WeatherForecast forecast = new WeatherForecast();
            forecast.Date = dateTime;
            forecast.TemperatureC = temperature;
            
            _forecasts.Add(forecast);
            return _forecasts.Last();
        }

        public WeatherForecast AddWeatherForecast(WeatherForecast forecast)
        {
            _forecasts.Add(forecast);
            return _forecasts.Last();
        }

        public WeatherForecast Update(int temperature, string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            int index = _forecasts.FindIndex(forcast => forcast.Date == dateTime);
            if (_forecasts.Count > 0 && index > 0 && index < _forecasts.Count)
            {
                _forecasts[index].TemperatureC = temperature;
                return _forecasts[index];
            }

            return null;
        }

        public WeatherForecast Remove(string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            WeatherForecast forecast = _forecasts.Find(forcast => forcast.Date == dateTime);
            _forecasts.Remove(forecast);
            
            return forecast;
        }

        public WeatherForecast Forecast(string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            return _forecasts.Find(forcast => forcast.Date == dateTime);
        }

        public List<WeatherForecast> AllForcasts()
        {
            return _forecasts;
        }

        private void SetupInitialValues()
        {
            _forecasts.Add(new WeatherForecast(DateTime.Today, 12));
            _forecasts.Add(new WeatherForecast(DateTime.Now.Subtract(TimeSpan.FromDays(1)), 10));
            _forecasts.Add(new WeatherForecast(DateTime.Now.Subtract(TimeSpan.FromDays(2)), 11));
            _forecasts.Add(new WeatherForecast(DateTime.Now.Subtract(TimeSpan.FromDays(3)), 7));
            _forecasts.Add(new WeatherForecast(DateTime.Now.Subtract(TimeSpan.FromDays(4)), 10));
        }
    }
}
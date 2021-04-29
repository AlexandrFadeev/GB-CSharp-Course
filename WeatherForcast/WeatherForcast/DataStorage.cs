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

        public void AddWeatherForecast(WeatherForecast forecast)
        {
            _forecasts.Add(forecast);
        }

        public WeatherForecast Update(int temperature, DateTime date)
        {
            var forecastAtDate = _forecasts.FirstOrDefault(forecast => forecast.Date == date);
            return forecastAtDate;
        }

        public WeatherForecast Remove(DateTime date)
        {
            WeatherForecast forecast = _forecasts.Find(forcast => forcast.Date == date);
            _forecasts.Remove(forecast);
            
            return forecast;
        }

        public WeatherForecast Forecast(DateTime date)
        {
            return _forecasts.Find(forcast => forcast.Date == date);
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
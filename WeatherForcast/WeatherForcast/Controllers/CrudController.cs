using System;
using Microsoft.AspNetCore.Mvc;

namespace WeatherForcast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private readonly DataStorage _dataStorage;

        public CrudController(DataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }
        
        [HttpGet("all")]
        public IActionResult GetAllForcasts()
        {
            return Ok(_dataStorage.AllForcasts());
        }

        [HttpGet("forcast")]
        public IActionResult GetForcastOfDate([FromQuery] DateTime date)
        {
            var forecast = _dataStorage.Forecast(date);
            return Ok(forecast);
        }

        [HttpPost("add/forcast")]
        public IActionResult CreateForcast([FromBody] WeatherForecast forecast)
        {
            _dataStorage.AddWeatherForecast(forecast);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] int temperature, [FromQuery] DateTime date)
        {
            var forecast = _dataStorage.Update(temperature, date);
            return Ok(forecast);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            var forecast = _dataStorage.Remove(date);
            
            // Should we send back deleted object after delete ?
            return Ok(forecast);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly ILogger _logger;
        private readonly IWeatherTest _test;

        public WeatherForecastController( IWeatherTest test)
        {
            //_logger = logger;
            _test = test;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_test.Do());
        }
    }
}

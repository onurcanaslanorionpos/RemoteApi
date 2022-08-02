using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly NorthwindContext _context;
        private readonly IHubContext<SappHub> _hubContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHubContext<SappHub> hubContext)
        {
            _logger = logger;
            _context = new NorthwindContext();
            _hubContext = hubContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetRegion")]
        public string GetRegion()
        {
            return _context.Regions.FirstOrDefault().RegionDescription;
        }

        [HttpGet("GetRegions")]
        public List<string> GetRegions()
        {
            return _context.Regions.Select(s=>s.RegionDescription).ToList();
        }

        [HttpPost("SetRegion")]
        public async Task<bool> SetRegion(string name)
        {
            
            try
            {
                await _hubContext.Clients.All.SendAsync("receiveMessage", name);
            }
            catch (Exception)
            {
            }

            return true;
            try
            {
                _context.Regions.Add(new Region { RegionDescription = name });
                _context.SaveChanges();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}

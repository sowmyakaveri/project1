using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace TestApi.API.Controllers
{
    //http:localhost:5000/api/weatherforecast
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        //GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var value = await _context.Values.ToListAsync();
            return Ok(value);
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.MyProperty == id);
            return Ok(value);
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {    
        }

        //DELETE api/values/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {

         }
       // private static readonly string[] Summaries = new[]
        //{
           // "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

       // private readonly ILogger<WeatherForecastController> _logger;

       
    }
}

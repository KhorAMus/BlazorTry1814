using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTry1814Api.Controllers
{
    [Route("random/[controller]")]
    [ApiController]
    public class IntegerController : ControllerBase
    {        
        public object GetInteger(int from = 1, int to = 101)
        {
            var random = new Random();
            var randomNumber = random.Next(from, to);

            return new { Value = randomNumber };
        }
    }
}

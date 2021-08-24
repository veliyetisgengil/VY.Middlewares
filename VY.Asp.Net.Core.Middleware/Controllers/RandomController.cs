using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VY.Asp.Net.Core.Middleware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
     

        [HttpGet]
        public String Get()
        {
            Random random = new Random();

            int number = random.Next(0, 100);
            
            if(number > 50)
            {
                return "Congratulations !!! You Are Pass Class :)";
            }
            else
            {
                throw new Exception("Sorry You didn't pass the class :(");
            }
        }
    }
}

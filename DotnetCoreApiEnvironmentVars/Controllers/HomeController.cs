using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCoreApiEnvironmentVars.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotnetCoreApiEnvironmentVars.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly EnvironmentConfig _config;

        public HomeController(IOptions<EnvironmentConfig> config)
        {
            _config = config.Value;
        }

        [HttpGet("")]
        public IActionResult GetRoot()
        {
            //var message = Environment.GetEnvironmentVariable("message");
            var message = _config.Message;
            return Ok(message);
        }
    }
}

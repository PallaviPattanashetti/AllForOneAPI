using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Service;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;
        public HelloWorldController(HelloWorldServices helloWorldServices)
        {
            _helloWorldServices = helloWorldServices;
        }
        [HttpGet]
        [Route("GreetUser/{userName}")]
        public string GetGreeting(string userName)
        {
          
            return _helloWorldServices.GetGreeting(userName);
        }
    }
}
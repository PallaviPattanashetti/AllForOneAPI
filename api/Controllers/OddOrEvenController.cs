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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpGet]
        [Route("Fetch/{number}")]
        public string GetNumber(int number)
        {
            return _oddOrEvenServices.CheckOddOrEven(number);
        }
    }
}
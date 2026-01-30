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
    public class MagicBallController : ControllerBase
    {
        private readonly MagicBallServices _magicBallServices;
        public MagicBallController(MagicBallServices magicBallServices)
        {
            _magicBallServices = magicBallServices;
        }
        [HttpGet]
        [Route("Fetch/{Ask}")]
        public string GetResponse(string question)
        {
            return _magicBallServices.GetMagicAnswer();
        }
    }
}
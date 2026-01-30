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
    public class AskQueController : ControllerBase
    {
        private readonly AskQueServices _askQueServices;
        public AskQueController(AskQueServices askQueServices)
        {
            _askQueServices = askQueServices;
        }
        [HttpGet]
        [Route("Fetch/{name}/{time}")]
        public string GetHello(string name, string time)
{
    return _askQueServices.GetHello(name,time);
}

    }}
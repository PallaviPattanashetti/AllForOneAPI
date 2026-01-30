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
    public class NumReverseController : ControllerBase
    {
       private readonly NumReverseServices _numReverseServices ;
       private NumReverseServices numReverseServices;
       public NumReverseController(NumReverseServices numReverseServices)
        {
            _numReverseServices = numReverseServices;
        }
        [HttpGet]
        [Route("Fetch/number")]
        public string GetSequence(string numbers)
        {
            return _numReverseServices.GetSequence(numbers);
        }
    }
}
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
    public class AlphaReverseController : ControllerBase
    {
        private readonly AlphaReverseServices _alphaReverseServices;
        private AlphaReverseServices alphaReverseServices;
        public AlphaReverseController(AlphaReverseServices alphaReverseServices)
        {
            _alphaReverseServices = alphaReverseServices;
        }
        [HttpGet]
        [Route("Fetch/Letters")]
        public string GetSequence(string Letters)
        {
            return _alphaReverseServices.GetSequence(Letters);
        }
    }
}
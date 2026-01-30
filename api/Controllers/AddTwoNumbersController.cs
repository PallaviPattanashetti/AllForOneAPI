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
    public class AddTwoNumbersController : ControllerBase
    {
private readonly AddTwoNumbersServices _addTwoNumberServices;
public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumberServices = addTwoNumbersServices;
        }


       [HttpGet] 
       [Route("userInput/{userNum1}/{userNum2}")]
       public string GetNumber (int userNum1, int userNum2)
       {
            return _addTwoNumberServices.GetNumber(userNum1,userNum2);
        }
       
        
       
    }
}
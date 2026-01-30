using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class OddOrEvenServices
    {
         public string CheckOddOrEven(int number)
      {  
        if (number % 2 == 0)
        {
            return $"{number} is even number";
        }
        else{

            return $"{number} is odd number";
        }
    }
    }
}
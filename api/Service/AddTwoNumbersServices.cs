using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class AddTwoNumbersServices
    {
        public string GetNumber(int userNum1, int userNum2)
        {
            return ($"{userNum1}+{userNum2}={userNum1 + userNum2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class HelloWorldServices
    {
        public string GetGreeting(string userName)
        {
            return $"Hello, {userName}!";
        }
    }
}
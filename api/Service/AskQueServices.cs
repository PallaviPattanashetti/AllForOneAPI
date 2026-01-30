using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class AskQueServices
    {
        public string GetHello(string name, string time)
        {
            return$"{name} woke up at {time} today.";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class NumReverseServices
    {
        public string GetSequence(string number)
{
    string reversed = "";
    for (int i = number.Length - 1; i >= 0; i--)
    {
        reversed += number[i];
    }
    return $"you entered {number}, reversed: {reversed}";
}

    }
}
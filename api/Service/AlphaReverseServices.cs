using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class AlphaReverseServices
    {
        public string GetSequence(string Letters)
        {
            string reversed = "";
            for (int i = Letters.Length -1; i>=0; i--)
            {
                if (char.IsLetter(Letters[i]))
                {
                    reversed += Letters[i]; 
                }
               
            }
            return $"you entered {Letters}, reversed id {reversed}";
        }
    }
}
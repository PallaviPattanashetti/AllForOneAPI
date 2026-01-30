using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Service
{
    public class MadLabServices
    {
        public string GetInputs(string name, string place, string city, string noun, string adjective, string adverb, string animal, string sillyWord, string food, string otherfriends)
        {
            return $"One day {name} decides to visit {place} with his best friend {noun} in the afternoon. {adjective} and {adverb} both ran toward the shop with their {animal}. Both were hungry, when they heard a loud {sillyWord} sound and that was baking sound of {food}. After having heavy lunch both started walk towards {city} and met {otherfriends} in the downtown.";
        }
    }
}
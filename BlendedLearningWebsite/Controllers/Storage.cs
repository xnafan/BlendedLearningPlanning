using BlendedLearningWebsite.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlendedLearningWebsite.Controllers
{
    public static class Storage
    {
        private static Random _random = new Random();
        private static char[] _characters = new char[] {'2', '3', '4', '5', '6', '7', '8', '9', 
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public static Dictionary<string, Bruger> Brugere = new();

        public static Bruger CreateNewBruger()
        {
            Bruger bruger = new(CreateNewShortId());
            Brugere.Add(bruger.Id, bruger);
            return bruger;
        }

        private static string CreateNewShortId(int characters = 10)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < characters; i++)
            {
                builder.Append(_characters[_random.Next(_characters.Length)]);
            }
            return builder.ToString();
        }

        public static Bruger FindBruger(string brugerid)
        {
            if (!String.IsNullOrWhiteSpace(brugerid ) && Storage.Brugere.ContainsKey(brugerid))
            {
                return Brugere[brugerid];
            }
            return null;
        }
    }
}
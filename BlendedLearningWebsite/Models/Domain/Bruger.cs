using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlendedLearningWebsite.Models.Domain
{
    public class Bruger
    {
        public string Id { get; set; }
        public List<Forløb> Forløb { get; set; } = new();

        public Bruger(string id)
        {
            Id = id;
        }
    }
}

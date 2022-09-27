using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlendedLearningWebsite.Models.Domain
{
    public class Forløb
    {
        public Guid Id { get; set; }
        public Periode[] Perioder { get; set; } = new Periode[] { new Periode("Periode 1"), new Periode("Periode 2"), new Periode("Periode 3"), new Periode("Periode 4")};

        public string Navn { get; set; }

        public DateTime? CreationTime { get; set; }

        public Forløb(string navn) : this(Guid.NewGuid(), navn, DateTime.Now) {}

        public Forløb(Guid id, string navn, DateTime creationTime)
        {
            Id = id;
            CreationTime = creationTime;
            Navn = navn;
        }


        public override string ToString()
        {
            return Navn;
        }
    }
}

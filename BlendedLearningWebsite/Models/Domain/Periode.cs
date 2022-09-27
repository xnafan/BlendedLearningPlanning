namespace BlendedLearningWebsite.Models.Domain
{
    public class Periode
    {
        public string Navn { get; set; }

        public Periode(string navn) => Navn = navn;
    }
}
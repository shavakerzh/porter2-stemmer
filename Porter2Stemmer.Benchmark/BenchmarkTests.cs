using BenchmarkDotNet.Attributes;
using Porter2Stemmer;


namespace Benchmark
{
    public class BenchmarkTests
    {
        private readonly EnglishPorter2Stemmer _stemmer;
        private readonly string[] _words = new[]
        {
            "enclose",
            "enclosed",
            "enclosing",
            "enclosure",
            "enclosures",
            "encomium",
            "encomiums",
            "encompassed",
            "encompassing",
            "encore",
            "encounter",
            "encountered",
            "encountering",
            "encounters",
            "encourage",
            "break",
            "breaker",
            "breakers",
            "breakfast",
            "breakfasted",
            "breakfasting",
            "breakfasts",
            "breakin",
            "breaking",
        };

        public BenchmarkTests()
        {
            _stemmer = new EnglishPorter2Stemmer();
        }

        [Benchmark]
        public StemmedWord AbandonmentTest() => _stemmer.Stem("abandonment");

        public IEnumerable<StemmedWord> StemWords()
        {
            foreach (var word in _words)
            {
                yield return this._stemmer.Stem(word);
            }
        }
    }
}

using BenchmarkDotNet.Attributes;
using Porter2Stemmer;


namespace Benchmark
{
    public class BenchmarkTests
    {
        private readonly EnglishPorter2Stemmer _stemmer;

        public BenchmarkTests()
        {
            _stemmer = new EnglishPorter2Stemmer();
        }

        [Benchmark]
        public StemmedWord AbandonmentTest() => _stemmer.Stem("abandonment");
    }
}

using Benchmark;
using BenchmarkDotNet.Running;

//new BenchmarkTests().StemWords();
BenchmarkRunner.Run(typeof(BenchmarkTests).Assembly);

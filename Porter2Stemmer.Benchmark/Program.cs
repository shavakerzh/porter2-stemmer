using Benchmark;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(typeof(BenchmarkTests).Assembly);

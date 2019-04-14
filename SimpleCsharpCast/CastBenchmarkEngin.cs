using MappingComparison.Common;
using MappingComparison.Common.Dto;
using System;
using System.Diagnostics;
namespace SimpleCsharpCast
{
    public class CastBenchmarkEngin<T, U>
        where T : Person, new()
        where U : PersonDto, new()
    {
        private readonly int counter;
        public U Source;
        public CastBenchmarkEngin(int counter) => this.counter = counter;
        public void Start()
        {
            var timer = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                var ret = (T)this.Source;
            }
            timer.Stop();
            Console.WriteLine("Csharp cast Mapping for counter : {0} , time: \t{1}s", this.counter, timer.Elapsed.TotalSeconds);
        }
    }
}

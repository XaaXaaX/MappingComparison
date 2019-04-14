using SimpleCsharpCast;
using MappingComparison.Common.Dto;
using MappingComparison.Common;
using SimpleAutoMapperMapping;
using System;

namespace MappingComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10000000; i*=10)
            {
                new AutoMapperBenchmarkEngine<Person, PersonDto>(i).Sample().Start();
                new CastBenchmarkEngin<Person, PersonDto>(i).Sample().Start();
                Console.WriteLine("-----");
            }
        }
    }
}

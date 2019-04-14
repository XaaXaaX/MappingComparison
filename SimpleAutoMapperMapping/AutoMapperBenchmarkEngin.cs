using AutoMapper;
using System;
using System.Diagnostics;

namespace SimpleAutoMapperMapping
{
    public class AutoMapperBenchmarkEngine<T, U>
    {
        private readonly IMapper _mapper;
        private readonly int counter;
        public U Source;

        public AutoMapperBenchmarkEngine(int counter) {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, U>();
            });

            _mapper = config.CreateMapper();

            this.counter = counter;
        }
        
        public void Start()
        {
            var timer = Stopwatch.StartNew();

            for (int i = 0; i < this.counter; i++)
            {
                _mapper.Map<U, T>(Source);
            }

            timer.Stop();

            Console.WriteLine("AutoMapper Mapping for count :  {0} , time: \t{1}s  ",this.counter, timer.Elapsed.TotalSeconds);
        }
    }
}

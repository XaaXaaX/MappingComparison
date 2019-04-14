using MappingComparison.Common;
using MappingComparison.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAutoMapperMapping
{
    public static class AutoMapperBenchmarkEnginExtensions
    {
        public static AutoMapperBenchmarkEngine<Person, PersonDto> Sample(this AutoMapperBenchmarkEngine<Person, PersonDto> engine)
        {
            engine.Source = new PersonDto
            {
                FirstName = "Omid",
                FullName = "Omid Eidivandi",
                LastName = "Eidivandi",
                Address = new AddressDto
                {
                    CompAdress = "Avenue Général du Gaule",
                    Number = "102Bis",
                    ZipCode = "75002",
                    City = new CityDto
                    {
                        CityName = "Paris",
                        Country = new CountryDto
                        {
                            CountryCode = 33,
                            CountryName = "France"
                        },
                    }
                }
            };
            return engine;
        }
    }
}

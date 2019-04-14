namespace SimpleCsharpCast
{
    using MappingComparison.Common;
    using MappingComparison.Common.Dto;

    public static class CastBenchmarkEnginExtensions
    {
        public static CastBenchmarkEngin<Person, PersonDto> Sample(this CastBenchmarkEngin<Person, PersonDto> engine)
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

namespace MappingComparison.Common
{
    using MappingComparison.Common.Dto;

    public partial class Person
    {
        public static explicit operator Person(PersonDto personDto)
        {
            Person @this = new Person();
            @this.FirstName = personDto.FirstName;
            @this.LastName = personDto.LastName;
            @this.FullName = personDto.FullName;
            @this.BirthDate = personDto.BirthDate;
            @this.Address = new Address
            {
                Block = personDto.Address.Block,
                ZipCode = personDto.Address.ZipCode,
                CompAdress = personDto.Address.CompAdress,
                Number = personDto.Address.Number,
                City = new City
                {
                    CityName = personDto.Address.City.CityName,
                    Country = new Country
                    {
                        CountryCode = personDto.Address.City.Country.CountryCode,
                        CountryName = personDto.Address.City.Country.CountryName
                    }
                }
            };
            return @this;
        }
    }
}

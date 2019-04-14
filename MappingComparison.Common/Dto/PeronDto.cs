using System;
using System.Collections.Generic;
using System.Text;

namespace MappingComparison.Common.Dto
{
    public class PersonDto
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public AddressDto Address { get; set; }
    }
    public class CountryDto
    {
        public string CountryName { get; set; }
        public int CountryCode { get; set; }
    }

    public class CityDto
    {
        public string CityName { get; set; }
        public CountryDto Country { get; set; }
    }

    public class AddressDto
    {
        public string ZipCode { get; set; }
        public string CompAdress { get; set; }
        public string Number { get; set; }
        public string Block { get; set; }
        public CityDto City { get; set; }
    }

}

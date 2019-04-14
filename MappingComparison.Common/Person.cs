namespace MappingComparison.Common
{
    using System;

    public partial class Person
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
    }
}

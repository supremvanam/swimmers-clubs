using System;
namespace Library_301177430_A2
{
    public struct Address
    {
        public string City;
        public string PostalCode;
        public string Province;
        public string Street;

        public Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{Street} {City} {Province} {PostalCode}";
        }

    }
}

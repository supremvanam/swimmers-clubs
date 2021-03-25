using System;
using System.Collections.Generic;

namespace Library_301177430_A2
{
    public class Club
    {
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; private set; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public List<Registrant> Swimmers { get; }


        public Club()
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
        }

        public Club(string name, Address anAddress, ulong phoneNumber) : this()
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
        }

        internal Club(uint regNumber, string name, Address anAddress, ulong phoneNumber) : this(name, anAddress, phoneNumber)
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            // todo: Implement other classes

        }


        // todo: Implement other classes
        public override string ToString()
        {

            //var output;
            foreach (var swimmer in Swimmers)
            {

            }
            return "";
        }


    }
}

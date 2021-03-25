using System;
namespace Library_301177430_A2
{
    public class Registrant
    {
        private Club club;

        public Club Club
        {
            get
            {
                return club;
            }
            set
            {
                //todo: come back later
            }
        }


        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }

        public Registrant()
        {
            Id = RegistrationNumberGenerator.GetNext();
        }

        public Registrant(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }

        internal Registrant(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this(name, dateOfBirth, anAddress, phoneNumber)
        {
            Id = regNumber;

        }

        //todo: check again
        public override string ToString()
        {
            if (club != null)
            {
                return club.Name;
            }

            return "not assigned";
        }

    }
}

using System;
namespace Library_301177430_A2
{
    public static class RegistrationNumberGenerator
    {
        private static uint nextRegistrationNumber = 0;

        public static uint GetNext()
        {
            return nextRegistrationNumber++;
        }

    }
}

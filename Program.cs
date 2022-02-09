using System;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (true)
            {

                var name = Faker.Name.FullName();
                var address = Faker.Address.StreetName();
                var driversLicense = Faker.Identification.SocialSecurityNumber();
                var passportNum = Faker.Identification.UkPassportNumber();
                var mBI = Faker.Identification.MedicareBeneficiaryIdentifier();

                Console.WriteLine($"Name: {name}, Address: {address}, Drivers license: {driversLicense}, Passport number {passportNum} and Medicare beneficiary identifier: {mBI}");
                Console.WriteLine();

                if(i == 3)
                {
                    break;
                }
                i++;
            }    
        }
    }
}

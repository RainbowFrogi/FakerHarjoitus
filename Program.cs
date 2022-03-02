using System;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type --personcount, or --interactive");
            string count = Console.ReadLine();

            if (count != null)
            {
                if(count == "--personcount")
                {
                    NewMethod();
                    NewMethod();
                    NewMethod();
                }
                else if(count == "--interactive")
                {
                    Console.WriteLine("How many fake persons data you want?");
                    int amount = Convert.ToInt32(Console.ReadLine());

                    int i = 0;
                    while(i < amount)
                    {
                        NewMethod();

                        i++;
                    }
                }
            }
        }

        private static void NewMethod()
        {
            Console.WriteLine("");

            var name = Faker.Name.FullName();
            var address = Faker.Address.StreetName();
            var driversLicense = Faker.Identification.SocialSecurityNumber();
            var passportNum = Faker.Identification.UkPassportNumber();
            var mBI = Faker.Identification.MedicareBeneficiaryIdentifier();

            Console.WriteLine($"Name: {name}, Address: {address}, Drivers license: {driversLicense}, Passport number {passportNum} and Medicare beneficiary identifier: {mBI}");
        }
    }
}

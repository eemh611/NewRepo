using System;

namespace UserAgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            int currentYear = DateTime.Now.Year;

            int yearOfBirth;

            while (true)
            {
                Console.Write("Enter your year of birth: ");
                string yearOfBirthString = Console.ReadLine();

                bool yearOfBirthBool = int.TryParse(yearOfBirthString, out yearOfBirth);

                if (yearOfBirth > 0)
                {
                    if (yearOfBirth <= currentYear - 100)
                    {
                        Console.WriteLine($"Error, your year of birth cannot be less than {currentYear - 100} or greater than { currentYear }, please enter valid value");
                        continue;
                    }

                    if (yearOfBirth >= currentYear)
                    {
                        Console.WriteLine($"Error, your year of birth cannot be less than {currentYear - 100} or greater than { currentYear }, please enter valid value");
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input string, year of birth should be a four digit number");
                    continue;
                }

                break;
            }


            int userAge = currentYear - yearOfBirth;
            Console.WriteLine($"{userName} your age is {userAge}");

            int ageOfAdult = 18;

            if (userAge >= ageOfAdult)
                Console.Write("You are adult"); // if user age is greater than or equals to 18

            else
                Console.WriteLine("You are not adult"); // if user's age is less than 18
        }
    }
}

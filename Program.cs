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
            int yearOfBirth = 0;

            Console.Write("Enter your year of birth: ");
            string yearOfBirthString = Console.ReadLine();

            while (true)
            {
                if (!int.TryParse(yearOfBirthString, out yearOfBirth))
                {
                    OutputErrorMessageAndRequestTheText("Invalid input string, year of birth should be a four digit number");
                    yearOfBirthString = Console.ReadLine();
                    continue;
                }

                if ((currentYear - 100) <= yearOfBirth && yearOfBirth < currentYear)
                    break;

                OutputErrorMessageAndRequestTheText($"Error, your year of birth cannot be less than {currentYear - 100} or greater than { currentYear }, please enter valid value");
                yearOfBirthString = Console.ReadLine();
                continue;
            }

            int userAge = currentYear - yearOfBirth;
            Console.WriteLine($"\n{userName} your age is {userAge}");

            int ageOfAdult = 18;

            if (userAge >= ageOfAdult)
                Console.WriteLine("You are adult"); // if user age is greater than or equals to 18

            else
                Console.WriteLine("You are not adult"); // if user's age is less than 18


            Console.WriteLine("\nHow many places would you like to visit in 10 years ?");
            var numberPlacesString = Console.ReadLine();
            var numberPlaces = 0;

            while (true)
            {
                if (!int.TryParse(numberPlacesString, out numberPlaces))
                {
                    Console.WriteLine("Invalid input string, enter a positive integer numeric value between 0 and 10.");
                    numberPlacesString = Console.ReadLine();
                    continue;
                }

                if ( 0 <= numberPlaces && numberPlaces < 11)
                    break;

                Console.WriteLine("Invalid input string, enter a positive integer numeric value between 0 and 10.");
                numberPlacesString = Console.ReadLine();
                continue;
            }

            string[] places = new string[numberPlaces+1];
            var i = 1;

            for (Console.WriteLine("\nPlace current_number for example 1, 2, ..., 10"); i <= numberPlaces; ++i)
            {
                Console.Write($"\nPlaces №{i}: ");
                places[i] = Console.ReadLine();   
            }

            Console.WriteLine("\nPlaces you'd like to visit in 10 years: ");

            for (int n = 1; n < places.Length; n++)
            {
                Console.WriteLine($"{n}) {places[n]}");
            }
            Console.ReadKey();
        }
       
        private static void OutputErrorMessageAndRequestTheText(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Console.Write("Enter your year of birth: ");
        }
    }
}

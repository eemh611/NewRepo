using System;

namespace UserAgeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your year of birth: ");
            var yearOfBirth = GetYearOfBirth();

            int currentYear = DateTime.Now.Year;
            int userAge = currentYear - yearOfBirth;
            Console.WriteLine($"\n{userName} your age is {userAge}");

            int ageOfAdult = 18;

            if (userAge >= ageOfAdult)
                Console.WriteLine("You are adult");

            else
                Console.WriteLine("You are not adult");


            Console.WriteLine("\nHow many places would you like to visit in 10 years ?");
            var numberPlaces = GetNumberPlaces();

            var places = new string[numberPlaces];

            Console.WriteLine("\nPlace current_number for example 1, 2, ..., 10");

            for (int i = 0; i < places.Length; i++)
            {
                Console.Write($"\nPlaces №{i + 1}: ");
                places[i] = Console.ReadLine();
            }

            Console.WriteLine("\nPlaces you'd like to visit in 10 years: ");
            int currentPlaceNumber = 0;
            foreach (var place in places)
            {
                ++currentPlaceNumber;
                Console.WriteLine($"{currentPlaceNumber}) {place}");
            }
            Console.ReadKey();
        }

        private static void OutputErrorMessageAndRequestTheValue(string errorMessage, string requestAValue)
        {
            Console.WriteLine(errorMessage);
            Console.WriteLine(requestAValue);
        }

        private static int GetYearOfBirth()
        {
            var yearOfBirthString = Console.ReadLine();
            var currentYear = DateTime.Now.Year;
            var lowerAgeRang = DateTime.Now.Year - 100;
            var yearOfBirth = 0;
            const string errorMessage1 = "Invalid input string, year of birth should be a four digit number";
            const string errorMessage2Text = "Error, your year of birth cannot be less than {0}  or greater than {1}, please enter valid value";
            string errorMessage2 = string.Format(errorMessage2Text, lowerAgeRang, currentYear);

            const string requestAValue = "\nEnter your year of birth: ";

            while (true)
            {
                if (!int.TryParse(yearOfBirthString, out yearOfBirth))
                {
                    OutputErrorMessageAndRequestTheValue(errorMessage1, requestAValue);
                    yearOfBirthString = Console.ReadLine();
                    continue;
                }

                if (lowerAgeRang <= yearOfBirth && yearOfBirth < currentYear)
                    break;

                OutputErrorMessageAndRequestTheValue(errorMessage2, requestAValue);
                yearOfBirthString = Console.ReadLine();
                continue;
            }
            return yearOfBirth;
        }

        private static int GetNumberPlaces()
        {
            const string errorMessage = "Invalid input string, enter a positive integer numeric value between 0 and 10.";
            const string requestAValue = "How many places would you like to visit in 10 years ?";

            var numberPlacesString = Console.ReadLine();
            var numberPlaces = 0;
            while (true)
            {
                if (!int.TryParse(numberPlacesString, out numberPlaces))
                {
                    OutputErrorMessageAndRequestTheValue(errorMessage, requestAValue);
                    numberPlacesString = Console.ReadLine();
                    continue;
                }

                if (0 <= numberPlaces && numberPlaces < 11)
                    break;

                OutputErrorMessageAndRequestTheValue(errorMessage, requestAValue);
                numberPlacesString = Console.ReadLine();
                continue;
            }
            return numberPlaces;
        }
    }
}

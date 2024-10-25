using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_04
    {
        public static void Main()
        {
            Excercise_02();
            Excercise_03();
            Excercise_05();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the function x = y2+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Excercise_02()
        {
            Console.Write("Enter an integer value for y (from -5 to 5): ");
            int y;

            while (!int.TryParse(Console.ReadLine(), out y) || y < -5 || y > 5)
            {
                Console.WriteLine("Please enter an integer from -5 to 5.");
                Console.Write("Enter an integer value for y: ");
            }

            int x = (y * y) + (2 * y) + 1;

            Console.WriteLine($"For y = {y}, x = {x}");
        }

        /// <summary>
        /// Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour (miles/h).
        /// </summary>
        public static void Excercise_03()
        {
            // Enter distance
            Console.Write("Enter distance in kilometers: ");
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Distance must be positive !!!");
                Console.Write("Enter distance in kilometers: ");
            }

            // Enter time
            Console.Write("Enter time (hours): ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter time (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Enter time (seconds): ");
            int seconds = int.Parse(Console.ReadLine());

            double totalTimeInHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Speed in km/h
            double speedKmh = distance / totalTimeInHours;

            // Convert speed in km/h to miles/h (1 km = 0.621371 miles)
            double speedMph = speedKmh * 0.621371;


            Console.WriteLine($"Speed: {speedKmh} km/h");
            Console.WriteLine($"Speed: {speedMph} miles/h");
        }


        /// <summary>
        /// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void Excercise_05()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // If the character is a vowel
            if ("UEOAIueoai".IndexOf(inputChar) >= 0)
            {
                Console.WriteLine($"{inputChar} is a vowel.");
            }
            // If the character is a digit
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} is a digit.");
            }
            // If it's neither a vowel nor a digit, it's a symbol
            else
            {
                Console.WriteLine($"{inputChar} is a symbol.");
            }
        }
    }
}

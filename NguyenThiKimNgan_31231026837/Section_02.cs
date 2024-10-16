using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_02
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();
            Question_06();
            Question_07(); 
            Question_08();
            Question_09();
            Question_10(); 

            Console.WriteLine("Press any key to stop"); 
            Console.ReadKey();

        }
        /// <summary>
        ///  to Add / Sum Two Numbers
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}"); 
            Console.WriteLine($"{a} * {b} = {product}");

        }

        /// <summary>
        /// to Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter a number c = "); 
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter a number d = ");
            int d = int.Parse(Console.ReadLine());

            int swap_c = d;
            int swap_d = c;

            Console.WriteLine($"The swap value of {c} = {swap_c}");
            Console.WriteLine($"The swap value of {d} = {swap_d}");
        }

        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter the first floating point number = ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second floating point number = ");
            float num2 = float.Parse(Console.ReadLine());

            float product1 = num1 * num2;

            Console.WriteLine($"{num1} * {num2} = {product1}");
        }

        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter a value in feet: ");
            double feet = double.Parse(Console.ReadLine());

            double meters = feet * 0.3048;

            Console.WriteLine($"{feet} feet is equal to {meters} meters.");
        }

        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            //đổi từ C sang F
            Console.Write("Enter a value in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9/5) + 32;

            Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit} Fahrenheit.");
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius} Celsius.");
            
            //đổi từ F sang C
            Console.Write("Enter a value in Fahrenheit: ");
            double fahrenheit1 = double.Parse(Console.ReadLine());

            double celsius1 = (fahrenheit1 - 32)*5/9;

            Console.WriteLine($"{fahrenheit1} Fahrenheit is equal to {celsius1} Celsius.");
            Console.WriteLine($"{celsius1} Celsius is equal to {fahrenheit1} Fahrenheit.");

        }

        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of decimal: " + sizeof(decimal));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of short: " + sizeof(short));
        }

        /// <summary>
        /// to Print ASCII Value
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar; 

            int asciiValue = (int)character; 

            Console.WriteLine($"The ASCII value of '{character}' is {asciiValue}.");
        }

        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter the radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine($"The area of the circle with radius {radius} is {area}.");
        }

        /// <summary>
        ///  to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter the length of the side of the square: ");
            double sideLength = double.Parse(Console.ReadLine());

            double area = sideLength * sideLength;

            Console.WriteLine($"The area of the square with side length {sideLength} is {area}.");

        }

        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter the number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int weeks = remainingDays / 7;
        remainingDays = remainingDays % 7;

        Console.WriteLine($"{totalDays} days is approximately {years} years, {weeks} weeks, and {remainingDays} days.");

        }

    }

}

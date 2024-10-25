using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_03
    {
        public static void Main()
        {
            Excercise_01();
            Excercise_02();
            Excercise_03();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }

        /// <summary>
        /// to convert from degrees Celsius to Kelvin and Fahrenheit
        /// </summary>
        public static void Excercise_01()
        {
            do
            {
                Console.Write("Enter a number in Celsius: ");
                double celsius;

                bool res = double.TryParse(Console.ReadLine(), out celsius);

                if (res && (celsius >= -273))
                {
                    double kelvin = celsius + 273;
                    Console.WriteLine($"{celsius} Celsius is equal to {kelvin} Kelvin!");

                    double fahrenheit = (celsius * 18 / 10) + 32;
                    Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit} Fahrenheit ");

                    break;

                }
                else
                {
                    Console.WriteLine("Nhiet do toi thieu cua Celsius la -273 !!!");
                }

            } while (true);
        }


        /// <summary>
        /// to calculate the surface and volume of a sphere
        /// </summary>
        public static void Excercise_02()
        {
            Console.Write("Enter the radius of the sphere:  ");
            double radius;

            if (double.TryParse(Console.ReadLine(), out radius) && radius >= 0)
            {
                double surface = 4 * radius * radius * Math.PI;
                Console.WriteLine($"The surface of the sphere with radius {radius} is {surface} !");

                double volume = (4.0 / 3) * radius * radius * radius * Math.PI; // Sửa lại đây
                Console.WriteLine($"The volume of the sphere with radius {radius} is {volume} !");
            }
            else
            {
                Console.WriteLine("Bán kính phải là số dương!");
            }
        }



        /// <summary>
        /// to calculate the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
        /// </summary>
        public static void Excercise_03()
        { 
            Console.WriteLine("Number a =   ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Number b =   ");
            int b = int.Parse(Console.ReadLine());

            int add = a + b;
            int subtract = a - b;
            int multiply = a * b; 

            // Kiểm tra chia cho 0
            if (b != 0)
            {
                int divide = a / b;
                int mod = a % b;

                Console.WriteLine($" {a} + {b} = {add}");
                Console.WriteLine($" {a} - {b} = {subtract}");
                Console.WriteLine($" {a} * {b} = {multiply}");
                Console.WriteLine($" {a} / {b} = {divide}");
                Console.WriteLine($" {a} % {b} = {mod}"); 
            }
            else
            {
                Console.WriteLine("Không thể chia cho 0!");
            }
        }
    }
}

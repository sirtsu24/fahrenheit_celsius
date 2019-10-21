using System;

namespace Fahrenheit_celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program in C# Sharp that converts Fahrenheit into Celcius and vice versa.
            - The program enables the user to select if the user wants to convert into Celcius or into Farenheit.
            - After the user has made their choice, the program asks for an input, performs calculations and displays the result
            - fahrenheit = (celsius * 9) / 5 + 32;
            -celsius = (fahrenheit - 32) * 5 / 9; */

            string userChoise;
            int fahrenheit;
            int celsius;


            Console.WriteLine("Do you want to convert into Celsius or into Fahrenheit?");
            userChoise = Console.ReadLine();

            if (userChoise.ToUpper() == "CELSIUS")
            {
                Console.WriteLine("Insert fahrenheit value");
                fahrenheit = int.Parse(Console.ReadLine());
                int c = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit} fahrenheit equals {c} Celsius");
            }
            else 
            {
                Console.WriteLine("Insert Celsius value");
                celsius = int.Parse(Console.ReadLine());
                int f = (celsius * 9) / 5 + 32;
                Console.WriteLine($"{celsius} Celsius equals {f} Fahrenheit");
            }

        }
    }
}

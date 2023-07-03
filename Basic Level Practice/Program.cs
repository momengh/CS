using System;

namespace Basic_Level_Practice
{
    class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a float number:");
            float floatNumber = float.Parse(Console.ReadLine());

            if (floatNumber != null) 
            {
                Console.WriteLine(TypeCoversion.ConvertFloatToInt32(floatNumber));
            }
            else
                Console.WriteLine("Please enter a float number: ");


            Console.WriteLine("Please enter an integer number:");
            Int32 intNumber = Int32.Parse(Console.ReadLine());

            if (intNumber != null)
            {
                Console.WriteLine(TypeCoversion.ConvertInt32ToFloat(intNumber));
            }
            else
                Console.WriteLine("Please enter an integer number: ");
        }
    }
}
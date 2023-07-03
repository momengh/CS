using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Level_Practice
{
    internal class TypeCoversion
    {
        public static int ConvertFloatToInt32(float number1) {
            try
            {
                return Convert.ToInt32(number1);
            }
            catch (Exception message)
            {
                Console.WriteLine("Could not covert Float to Int32 - " + message);
                return -1;
            }
        }

        public static float ConvertInt32ToFloat(Int32 number1) 
        {
            try
            {
                return (float) number1;
            }
            catch (Exception message)
            {
                Console.WriteLine("Could not covert Int32 to float - " + message);
                return -1;
            }
        }
    }
}

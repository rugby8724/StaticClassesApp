using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            double output;
            bool isDouble = false;
          

            Console.WriteLine(numberText);

            isDouble = double.TryParse(numberText, out output);

            Console.WriteLine($"not while double = {isDouble}");
            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number, please try again");
                Console.WriteLine(message);
                numberText = Console.ReadLine();


                Console.WriteLine(numberText);

                isDouble = double.TryParse(numberText, out output);


            }

            return output;
        }

        public static string GetAString(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}

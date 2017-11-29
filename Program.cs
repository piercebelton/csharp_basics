using System;

namespace csharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //comments
            /* multiline
            comments */
            Console.Write("What is your name? ");
            string name = "Pierce";
            // string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // // booleans            
            bool canVote = true;

            // // single 16-bit character
            char grade = 'A';  

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;
            Console.WriteLine(maxInt);

            // Long Integer with a max value of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;
            Console.WriteLine(maxLong);

            // Float is a 32 bit number with MaxValue of 3.402823E+38 !!ONLY HAS 7 decimals of precision!
            float maxFloat = float.MaxValue;
            Console.WriteLine(maxFloat);

            // Double is a 32 bit number with a MaxValue of 1.79769313486232E+308  !!Precise to 15 decimals
            double maxDouble = double.MaxValue;
            Console.WriteLine(maxDouble);

            // Method to get data type of a variable
            Console.WriteLine("maxDouble is a {0}", maxDouble.GetTypeCode());

            //standard math operators:
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5 % 3 = " + (5 % 3));

            int i = 0;

            //standard incrementers:
            // prints to console THEN increments
            Console.WriteLine("i++ =" + (i++));

            // increments THEN prints to console
            Console.WriteLine("++i =" + (++i));

            // prints to console THEN decrements
            Console.WriteLine("i-- =" + (i--));

            // decrements THEN prints to console
            Console.WriteLine("--i =" + (--i));

            //standard math + variable reassignment:
            Console.WriteLine("i += 2 "  + (i += 2));
            Console.WriteLine("i -= 2 "  + (i -= 2));
            Console.WriteLine("i *= 2 "  + (i *= 2));
            Console.WriteLine("i /= 2 "  + (i /= 2));
            Console.WriteLine("i %= 2 "  + (i %= 2));




        }
    }
}

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

            // booleans            
            bool canVote = true;

            // single 16-bit character
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

            //standard math operators
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5 % 3 = " + (5 % 3));

            int i = 0;

            //standard incrementers
            // prints to console THEN increments
            Console.WriteLine("i++ =" + (i++));

            // increments THEN prints to console
            Console.WriteLine("++i =" + (++i));

            // prints to console THEN decrements
            Console.WriteLine("i-- =" + (i--));

            // decrements THEN prints to console
            Console.WriteLine("--i =" + (--i));

            //standard math + variable reassignment
            Console.WriteLine("i += 2 "  + (i += 2));
            Console.WriteLine("i -= 2 "  + (i -= 2));
            Console.WriteLine("i *= 2 "  + (i *= 2));
            Console.WriteLine("i /= 2 "  + (i /= 2));
            Console.WriteLine("i %= 2 "  + (i %= 2));

            
            // data type reassignment
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine("pi is a " + pi.GetTypeCode());
            Console.WriteLine("intPi is an " + intPi.GetTypeCode());


            // more math functions
            double num1 = 12.5;
            double num2 = 19;

            // returns absolute value
            Console.WriteLine("Math.Abs(num1) " + (Math.Abs(num1)));

            // returns number rounded up
            Console.WriteLine("Math.Ceiling(num1) " + (Math.Ceiling(num1)));

            // returns number rounded down
            Console.WriteLine("Math.Floor(num1) " + (Math.Floor(num1)));

            // takes in two integers, returns higher value
            Console.WriteLine("Math.Max(num1, num2) " + (Math.Max(num1, num2)));

            // takes in two integers, returns lower value
            Console.WriteLine("Math.Min(num1, num2) " + (Math.Min(num1, num2)));

            // returns first int to the power of second int
            Console.WriteLine("Math.Pow(num1, num2) " + (Math.Pow(num1, num2)));

            // returns number rounded based on standard rules
            Console.WriteLine("Math.Round(num1) " + (Math.Round(num1)));

            // returns square root of int
            Console.WriteLine("Math.Sqrt(num1) " + (Math.Sqrt(num1)));



            // random numbers
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (rand.Next(1, 11)));



            // Relational Operators: > < >= <= == !=
            // Logical Operators: && || ^ !
            // if/else and switch statements
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            } else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            } else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("!true = " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                    Console.WriteLine("Toddler");
                    goto Terrible;
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            Terrible:
            Console.WriteLine("Toddlers are terrible");



            // Loops
            int j = 0;

            while(j < 10)
            {
                if (j == 7)
                {
                    j++;
                    continue; // ignores rest of code and starts loop again.
                }

                if (j == 9)
                {
                    break; // breaks out of loop
                }

                if (j % 2 > 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }


            string guess;

            // do
            // {
            //  Console.WriteLine("Guess a Number ");
            //  guess = Console.ReadLine();   
            // } while (!guess.Equals("15"));

            for (int k = 0; k < 10; k++)
            {
                if (k % 2 > 0)
                {
                    Console.WriteLine(k);
                }
            }

            string randStr = "Here are some random characters";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }



            // More string stuff
            /*
            escapes:
            \' // single quote 
            \" // double quote 
            \\  // backslash
            \b  // backspace
            \n  // newline
            \t  // tab 
            */

            string sampString = "A bunch of random words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is white space " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("Length of string is " + sampString.Length);
 
        }
    }
}


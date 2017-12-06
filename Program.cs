// Default namespace, required for all C# apps
using System;

// req'd for StringBuilder 
using System.Text;

// req'd for List data type
using System.Collections.Generic;

namespace csharp_basics
{
    class Animal
    {
        // public: access unlimited
        // protected: limits access to specific class methods and sub-class methods
        // private: limits access to specific class methods

        // auto getters and setters
        public double height {get; set;}
        public double weight {get; set;}
        public string sound {get; set;}

        // manually creating getters and setters, in case we need constraints etc.
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // setting default values
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        // initializing an object
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }


        // static so that it is not called by the class
        // static methods cannot access class attributes
        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weights {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        //method overloading 
        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            // init object using constructor
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            Animal jackie = new Animal
            {
                name = "Jackie",
                height = 7,
                weight = 13,
                sound = "ruff"
            };

            //calling object attributes
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            //calling class methods
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            //calling object methods
            Console.WriteLine(spot.toString());

            //method overloading allows multiple types
            Console.WriteLine(spot.getSum(1, 2));
            Console.WriteLine(spot.getSum(1.2, 3.5));


            Console.WriteLine(spot.getSum(num2: 3.7, num1: 2.5));



            
            
            //comments
            /* multiline
            comments */
            
            /* commenting old code to clean up terminal
            
            
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
                    Console.WriteLine("Toddlers are terrible");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            



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
            
            escapes:
            \' // single quote 
            \" // double quote 
            \\  // backslash
            \b  // backspace
            \n  // newline
            \t  // tab 
            

            string sampString = "A bunch of random words";
            string sampString2 = "more random words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is white space " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("Length of string is " + sampString.Length);

            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));
            Console.WriteLine("2nd Word " +  sampString.Substring(2, 6));
            Console.WriteLine("Strings Equal? " + sampString.Equals(sampString2));
            Console.WriteLine("Starts with \"A bunch\" " + sampString.StartsWith("A bunch"));
            Console.WriteLine("ends with random words " + sampString.EndsWith("random words"));

            sampString = sampString.Trim(); // also TrimEnd and TrimStart

            sampString.Replace("words", "characters");
            Console.WriteLine(sampString);

            sampString.Remove(0, 2);

            string[] names = new string[3] {"Pierce", "Dad", "Melissa"};

            Console.WriteLine("Name List: " + String.Join(", ", names));

            // string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56);

            // Console.WriteLine(fmtStr);




            // String builder

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            Console.WriteLine(sb);

            sb.AppendFormat("My name is {0} and I live in {1}", "Pierce", "San Diego");
            Console.WriteLine(sb);

            //replaces all "a"s with "e"s
            sb.Replace("a","e");
            Console.WriteLine(sb);

            //deletes everything in index 5 UP TO BUT NOT INCLUDING 7
            sb.Remove(5, 7);
            
            sb.Clear();




            //Arrays

            int[] randNumArray;

            int[] randArray = new int[5];
            
            int[] randArray2 = {1, 2, 3, 4, 5};

            Console.WriteLine("Array Length " + randArray2.Length);

            Console.WriteLine("Array Item 0 " + randArray2[0]);

            for (int k = 0; k< randArray2.Length; k++)
            {
                Console.WriteLine("{0} : {1}", k, randArray2[k]);
            }

            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1? Index: " + Array.IndexOf(randArray2, 1));

            string[] familyNames = {"Pierce", "Melly", "Bruce"};

            string nameStr = string.Join(", ", familyNames);
            Console.WriteLine(nameStr);

            string[] nameArray = nameStr.Split(',');
            Console.WriteLine(nameArray);

            int[,] multArray = new int[5, 3];

            int[,] multArray2 = {{0, 1}, {2, 3}, {4, 5}};

            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            // for (int a = 0; a < multArray2.GetLength(0); a++)
            // {
            //     for(int b = 0; b < multArray2.GetLength(1); b++)
            //     {
            //         Console.WriteLine("{0} | {1} : {2}" + a, b, multArray2[a,b]);
            //     }
            // }
 


            // Lists

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(8);
            numList.Add(12);

            int[] randArray3 = {1, 2, 3, 4, 5};
            numList.AddRange(randArray);

            List<int> numList2 = new List<int>(randArray3);

            List<int> numList3 = new List<int>(new int[] {1, 2, 3, 4});

            // inserts "10" into index 1 of the list
            numList.Insert(1, 10);

            // removes value 5 from the list
            numList.Remove(5);

            // remove item at index of 2 from list
            numList.RemoveAt(2);

            for (int c = 0; c < numList.Count; c++)
            {
                Console.WriteLine(numList[c]);
            }

            // finds index of a value, returns -1 if not found
            Console.WriteLine("4 is in index " + numList3.IndexOf(4));

            Console.WriteLine("5 in List? " + numList.Contains(5));

            List<string> strList = new List<string>(new string[] {"Tom", "Paul"});

            Console.WriteLine("Tom in List? " + strList.Contains("Tom"));

            strList.Sort();
        



            //Exception handling

            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10/num));
            }

            // catches specific exceptions
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException("Operation Failed", ex);
            }

            // generic exception handler
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            */

        }
    }
     //initialize Dog class as a child of Animal
    class Dog : Animal
    {
        public string favFood { get; set; }

        // : base() adds constructors from parent class as well
        public Dog() : base()
        {
            this.favFood = "No Favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }
    }

}


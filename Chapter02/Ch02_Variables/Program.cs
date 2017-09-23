using System;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object
            //int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; //cast to access members

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but might throw an exception at run-time!
            int length = anotherName.Length;

            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; //chars use single-quotes
            var happy = true; // Booleans have value of true or false

            Console.WriteLine($"{default(int)}"); // 0
            Console.WriteLine($"{default(bool)}"); // False
            Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            int iCanNotBeNull = 4;
            int? iCanBeNull = null;
            Console.WriteLine(iCanBeNull.GetValueOrDefault());
            iCanBeNull = 4;
            Console.WriteLine(iCanBeNull.GetValueOrDefault());
        }
    }
}

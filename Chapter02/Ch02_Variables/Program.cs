using System;
using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // The object type
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object
            //int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; //cast to access members

            // The dynamic type
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but might throw an exception at run-time!
            int length = anotherName.Length;

            // Inferring the type of a local variable
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; //chars use single-quotes
            var happy = true; // Booleans have value of true or false

            // Displaying output to the user
            Console.WriteLine($"The UK population is {population}.");
            Console.WriteLine($"The UK population is {population:N0}. ");
            Console.WriteLine($"{weight}kg of {fruit} costs {price:C}.");

            WriteLine($"{default(int)}"); // 0
            WriteLine($"{default(bool)}"); // False
            WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            // Making a value type nullable
            int iCanNotBeNull = 4;
            int? iCanBeNull = null;
            WriteLine(iCanBeNull.GetValueOrDefault());
            iCanBeNull = 4;
            WriteLine(iCanBeNull.GetValueOrDefault());

            // Checking for null
            // Check is myVariable is not null before using it
            if (iCanBeNull != null)
            {
                WriteLine($"{nameof(iCanBeNull)} is not null");
            }

            // Checking for null for variable field or property
            string authorName = null;
            // if authorName is null, instead of throwing an exception,
            // null is returned
            int? howManyLetters = authorName?.Length;
            WriteLine($"Variable {nameof(howManyLetters)} is: {howManyLetters}");
            // next line should throw an NullException
            //int? howManyLetters = authorName.Length;

            // result will be three if howManyLetters is null
            var result = howManyLetters ?? 3;
            WriteLine($"Variable {nameof(result)} is: {result}");

            // Storing multiples values in an array
            // declaring the size of the array
            string[] names = new string[] { "Daddy", "Mommy", "Baby" };
            WriteLine($"The length of {nameof(names)} variable is: {names.Length}");
            for (int i = 0; i < names.Length; i++)
            {
                // read the itemat this index
                WriteLine(names[i]);
            }
        }
    }
}
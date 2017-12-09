using System;
using System.IO;
using System.Xml;
using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Literal values
            //Storing text
            char letter = 'A';
            //string name = "Bob";

            // Storing numbers
            int myIntegerNumber = 23;
            double myRealNumber = 2.3;

            //Storing whole numbers
            int decimalNotation = 2_000_000; // 2 million
            int binaryNotation = 0b0001_1110_1000_0100_1000_0000; // 2 million
            int hexdecimalNotation = 0x001E_8480;  // 2 million

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
            //int population = 66_000_000; // 66 million in UK
            //double weight = 1.88; // in kilograms
            //decimal price = 4.99M; // in pounds sterling
            //string fruit = "Apples"; // strings use double-quotes
            //char letter = 'Z'; //chars use single-quotes
            //bool happy = true; // Booleans have value of true or false

            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; //chars use single-quotes
            var happy = true; // Booleans have value of true or false

            // Good Practice
            // Good use of var
            var xml1 = new XmlDocument();
            // unnecessarily verbose repeating XmlDocument
            XmlDocument xml2 = new XmlDocument();

            // bad use of var; what data type is file1?
            var file1 = File.CreateText(@".\something.txt");
            // good use of a specific type declaration
            StreamWriter file2 = File.CreateText(@".\something.txt");

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
            // Check if myVariable is not null before using it
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
                // read the item at this index
                WriteLine(names[i]);
            }

            // Getting input from the user
            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}
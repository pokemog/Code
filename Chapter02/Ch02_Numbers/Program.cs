using System;

namespace Ch02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            double a = 0.1;
            double b = 0.2;
            decimal c = 0.1m;
            decimal d = 0.2m;
            if (a + b == 0.3)
            {
                Console.WriteLine($"Double type {a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"Double type {a} + {b} does NOT equal 0.3");
            }

            if (c + d == 0.3m)
            {
                Console.WriteLine($"Decimal type {c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"Decimal type {c} + {d} does NOT equal 0.3");
            }
        }
    }
}

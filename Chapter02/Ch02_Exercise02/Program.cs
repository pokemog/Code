using System;
using static System.Console;

namespace Ch02_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dash = "-";

            WriteLine($"{dash.PadLeft(120, '-')}");
            WriteLine($"{"Type",-20}{"Byte(s) of memory",-20}{"Min",-35}{"Max",-35}");
            WriteLine($"{typeof(sbyte),-20}{sizeof(sbyte),-20}{sbyte.MinValue,-35}{sbyte.MaxValue,-35}");
            WriteLine($"{typeof(byte),-20}{sizeof(byte),-20}{byte.MinValue,-35}{byte.MaxValue,-35}");
            WriteLine($"{typeof(short),-20}{sizeof(short),-20}{short.MinValue,-35}{short.MaxValue,-35}");
            WriteLine($"{typeof(ushort),-20}{sizeof(ushort),-20}{ushort.MinValue,-35}{ushort.MaxValue,-35}");
            WriteLine($"{typeof(int),-20}{sizeof(int),-20}{int.MinValue,-35}{int.MaxValue,-35}");
            WriteLine($"{typeof(uint),-20}{sizeof(uint),-20}{uint.MinValue,-35}{uint.MaxValue,-35}");
            WriteLine($"{typeof(long),-20}{sizeof(long),-20}{long.MinValue,-35}{long.MaxValue,-35}");
            WriteLine($"{typeof(ulong),-20}{sizeof(ulong),-20}{ulong.MinValue,-35}{ulong.MaxValue,-35}");
            WriteLine($"{typeof(float),-20}{sizeof(float),-20}{float.MinValue,-35}{float.MaxValue,-35}");
            WriteLine($"{typeof(double),-20}{sizeof(double),-20}{double.MinValue,-35}{double.MaxValue,-35}");
            WriteLine(value: $"{typeof(decimal),-20}{sizeof(decimal),-20}{decimal.MinValue,-35}{decimal.MaxValue,-35}");
            WriteLine($"{dash.PadLeft(119, '-')}");
        }
    }
}

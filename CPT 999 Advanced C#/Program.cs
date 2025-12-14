using System;

namespace TypeProgram
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"{"Type",-10}{"Byte(s) of memory",-40}{"Min",-20}{"Max"}");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine($"{"sbyte",-10}{"1",-40}{"-128",-20}{"127"}");
            Console.WriteLine($"{"byte",-10}{"1",-40}{"0",-20}{"255"}");
            Console.WriteLine($"{"short",-10}{"2",-40}{"-32768",-20}{"32767"}");
            Console.WriteLine($"{"ushort",-10}{"2",-40}{"0",-20}{"65535"}");

            Console.ReadLine();
        }
    }
}
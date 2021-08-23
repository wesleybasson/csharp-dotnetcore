using System;

namespace InitializeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing integers:
            int a, b, c;
            Console.WriteLine("Provide the first value:");
            a = int.Parse(Console.ReadLine()); // We must parse the string value to an integer
            Console.WriteLine("Provide the second value:");
            b = int.Parse(Console.ReadLine()); // We must parse the string value to an integer
            c = a + b;

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
            Console.ReadLine();

            // Initializing floating point numbers:
            double x, y, z;
            Console.WriteLine("Provide the value to be divided by 2.5:");
            x = double.Parse(Console.ReadLine());
            y = 2.5D; // End the number with a D (a float ends in an F)
            z = x / y;

            Console.WriteLine("{0} divided by 2.5 is {1}", x, z);
            Console.ReadLine();

            // It is better to use double instead of float. Float's size is 4 bytes whereas double's size is 8 bytes.
            // This means the precision of a float is up to seven decimal digits whereas the precision of a double is up to fifteen digits.

            // Initializing longs:
            long p, q, r;
            Console.WriteLine("Provide the value to be multiplied with 1234:");
            p = long.Parse(Console.ReadLine());
            q = 1234L; // End the long with an L
            r = p * q;

            Console.WriteLine("The product of {0} and 1234 is {1}", p, r);
            Console.ReadLine();

            // Longs are used for large whole numbers that are too large for int.
            // Longs can be used from -9223372036854775808 to 9223372036854775807.
        }
    }
}

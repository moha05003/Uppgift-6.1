using System;
namespace Uppgift_6_1
{
    class program
    {
        static void Main(string[]args)
        {
            Addera(5, 4, 3);
            Console.WriteLine(Addera(5, 4, 3));

        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
    }
}